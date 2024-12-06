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

        if (user is null)
        {
            return BadRequest();
        }
        
        var teacher = await _context.Teachers
            .Include(teacher => teacher.Grades)
            .ThenInclude(grade => grade.Student).ThenInclude(student => student.Grades)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        if (teacher is null)
        {
            return BadRequest();
        }

        var studentsInClass = await _context.Students
            .Include(student => student.Grades)
            .Where(student => student.ClassId == classId)
            .ToListAsync();

        var models = studentsInClass
            .Select(student => new TeacherGradesViewModel
            {
                StudentId = student.Id,
                StudentName = $"{student.FirstName} {student.MiddleName} {student.LastName}",
                Grades = student.Grades
                    .Where(g => g.Subject == teacher.Subject)
                    .ToList()
            })
            .ToList();

        return View(models);
    }

    [HttpPost]
    public async Task<IActionResult> AddGrade(int gradeValue, Guid studentId)
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        if (user is null)
        {
            return BadRequest();
        }
        
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);
        
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == studentId);

        if (teacher is null || student is null)
        {
            return BadRequest();
        }

        Grade grade = new Grade()
        {
            StudentId = student.Id,
            TeacherId = teacher.Id,
            Subject = teacher.Subject,
            GradeValue = gradeValue,
        };

        var classId = student.ClassId;
        
        student.Grades.Add(grade);
        _context.Update(student);
        await _context.SaveChangesAsync();

        return RedirectToAction("ClassGrades", "Teacher", new { classId });
    }

    public async Task<IActionResult> DeleteGrade(int gradeId, Guid studentId)
    {
        var grade = await _context.Grades.FirstOrDefaultAsync(g => g.Id == gradeId);
        var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == studentId);
        
        var user  = await _userManager.GetUserAsync(HttpContext.User);
        if (user is null)
        {
            return BadRequest();
        }        
        
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.Id == user.AppId);

        if (grade is null || student is null || teacher is null)
        {
            return BadRequest();
        }
        
        var classId = student.ClassId;

        if (grade.TeacherId == teacher.Id)
        {
            student.Grades.Remove(grade);
            _context.Update(student);
            _context.Remove(grade);
            await _context.SaveChangesAsync();
        }
        
        return RedirectToAction("ClassGrades", "Teacher", new { classId });
    }
}