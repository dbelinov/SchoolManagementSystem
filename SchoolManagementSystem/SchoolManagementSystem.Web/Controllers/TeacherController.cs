using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Web.Controllers;

[Authorize(Roles = nameof(Teacher))]
[AutoValidateAntiforgeryToken]
public class TeacherController : Controller
{
    private readonly ITeacherService _teacherService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public TeacherController(ITeacherService teacherService, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
    {
        _teacherService = teacherService;
        _userManager = userManager;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Dashboard()
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetDashboardAsync(userId);

        if (model == null)
        {
            return RedirectToAction("Index", "Home");
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> GradesDashboard()
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetGradesDashboardAsync(userId);

        if (model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> ClassGrades(int classId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetClassGradesAsync(classId, userId);

        if (model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> AddGrade(int gradeValue, Guid studentId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var success = await _teacherService.AddGradeAsync(gradeValue, studentId, userId);

        if (success is null)
        {
            return BadRequest();
        }

        return RedirectToAction("ClassGrades", "Teacher", new { classId = success });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteGrade(int gradeId, Guid studentId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var success = await _teacherService.DeleteGradeAsync(gradeId, studentId, userId);

        if (success is null)
        {
            return BadRequest();
        }

        return RedirectToAction("ClassGrades", "Teacher", new { classId = success });
    }

    public async Task<IActionResult> Scoreboard()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return BadRequest();
        }

        var teacher = await _context.Teachers
            .Include(t => t.TeachersClasses)
            .ThenInclude(tc => tc.Class)
            .ThenInclude(c => c.Students)
            .ThenInclude(student => student.Grades)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        if (teacher == null)
        {
            return BadRequest();
        }

        var classes = teacher.TeachersClasses.Select(c => c.Class).ToList();

        var students = classes
            .SelectMany(c => c.Students)
            .Distinct()
            .ToList();

        var studentScoreboard = students
            .Select(s => new StudentScoreboardViewModel
            {
                FullName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                ClassName = s.Class.Name,
                AverageGrade = s.Grades.Any(g => g.Subject == teacher.Subject) ? s.Grades
                    .Average(g => g.GradeValue) : 0 
            })
            .ToList();


        var classesScoreboard = classes
            .Select(c => new ClassScoreboardViewModel
            {
                ClassName = c.Name,
                AverageGrade = c.Students
                    .Where(s => s.Grades
                        .Any(g => g.Subject == teacher.Subject))
                    .Select(s => s.Grades.Average(g => g.GradeValue))
                    .DefaultIfEmpty(0)
                    .Average()
            })
            .ToList();

        var model = new ScoreboardViewModel
        {
            ClassScores = classesScoreboard,
            StudentScores = studentScoreboard,
        };
        
        return View(model);
    }
}