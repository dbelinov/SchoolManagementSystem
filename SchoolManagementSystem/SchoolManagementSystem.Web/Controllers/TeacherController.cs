using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers;

[Authorize(Roles = nameof(Teacher))]
public class TeacherController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public TeacherController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    [HttpGet]
    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);
    
        if (user is null)
        {
            ModelState.AddModelError("user", NotLoggedIn);
            return RedirectToAction("Index", "Home");
        }

        var teacher = await _context.Teachers
            .Include(teacher => teacher.Grades)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        if (teacher is null)
        {
            ModelState.AddModelError("user", InvalidUser);
            return RedirectToAction("Index", "Home");
        }
        
        var averageGrades = teacher.Grades.Any(g => g.Subject == teacher.Subject)
            ? teacher.Grades
                .Where(g => g.Subject == teacher.Subject)
                .Average(s => s.GradeValue).ToString("f2")
            : "0.0";

        var model = new TeacherDashboardViewModel
        {
            AverageGrade = averageGrades,
            GradesCount = teacher.Grades
                .Where(g => g.Subject == teacher.Subject)
                .ToList().Count,
        };
        
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> GradesDashboard()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);
        
        var teacher = await _context.Teachers
            .Include(teacher => teacher.TeachersClasses)
            .ThenInclude(teacherClass => teacherClass.Class)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        var models = new TeacherClassesViewModel
            {
                TeacherName = $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}",
                Classes = teacher.TeachersClasses
                    .Select(tc => new ClassViewModel
                    {
                        Id = tc.ClassId,
                        ClassName = tc.Class.Name,
                    })
                    .ToList(),
            };
        
        return View(models);
    }

    [HttpGet]
    public async Task<IActionResult> ClassGrades(int classId)
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);
        
        var teacher = await _context.Teachers
            .Include(teacher => teacher.Grades)
            .ThenInclude(grade => grade.Student).ThenInclude(student => student.Grades)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        var models = teacher.Grades
            .GroupBy(g => g.Student)
            .Where(g => g.Key.ClassId == classId)
            .Select(g => new TeacherGradesViewModel
            {
                StudentName = $"{g.Key.FirstName} {g.Key.MiddleName} {g.Key.LastName}",
                Grades = g.Key.Grades
                    .Where(g => g.Subject == teacher.Subject)
                    .ToList(),
            })
            .ToList();

        return View(models);
    }
}