using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers;

[Authorize(Roles = "Student")]
public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    
    public StudentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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
        
        var student = await _context.Students
            .Include(student => student.StudentGrades)
            .Include(student => student.StudentsProjects)
            .FirstOrDefaultAsync(s => s.Id == user.AppId);

        if (student is null)
        {
            ModelState.AddModelError("user", InvalidUser);
            return RedirectToAction("Index", "Home");
        }

        var averageGrades = "0.0";
        if (student.StudentGrades.Any())
        {
            averageGrades = student.StudentGrades.Average(s => s.Grade).ToString("f2");
        }

        var model = new StudentDashboardViewModel
        {
            AverageGrade = averageGrades,
            GradesCount = student.StudentGrades.Count,
            ProjectsCount = student.StudentsProjects.Count,
        };
        
        return View(model);
    }

    public async Task<IActionResult> Grades()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);
        
        if (user is null)
        {
            ModelState.AddModelError("user", NotLoggedIn);
            return RedirectToAction("Index", "Home");
        }
        
        var student = await _context.Students
            .Include(student => student.StudentGrades)
            .Include(student => student.StudentsProjects)
            .FirstOrDefaultAsync(s => s.Id == user.AppId);

        if (student is null)
        {
            ModelState.AddModelError("user", InvalidUser);
            return RedirectToAction("Index", "Home");
        }
        
        await AddGradesToIvan();

        var models = student.StudentGrades
            .GroupBy(sg => sg.Subject)
            .Select(g => new StudentGradesViewModel
            {
                Subject = g.Key,
                Grades = student
                    .StudentGrades
                    .Where(gr => gr.Subject == g.Key)
                    .ToList()
            })
            .ToList();
        
        return View(models);
    }

    //Test Purposes
    private async Task AddGradesToIvan()
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.FirstName == "Ivan");

        var grade1 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 6,
            Subject = Subject.Biology
        };

        var grade2 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 5,
            Subject = Subject.Biology
        };

        var grade3 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 6,
            Subject = Subject.Maths
        };
        
        student.StudentGrades.Add(grade1);
        student.StudentGrades.Add(grade2);
        student.StudentGrades.Add(grade3);
        
        await _context.SaveChangesAsync();
    }
}