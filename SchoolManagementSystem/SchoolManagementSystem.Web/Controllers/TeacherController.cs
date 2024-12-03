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
        
        var averageGrades = teacher.Grades.Any()
            ? teacher.Grades.Average(s => s.GradeValue).ToString("f2")
            : "0.0";

        var model = new TeacherDashboardViewModel
        {
            AverageGrade = averageGrades,
            GradesCount = teacher.Grades.Count,
        };
        
        return View(model);
    }
}