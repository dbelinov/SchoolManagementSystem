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

        var model = await _context.Teachers
            .Where(t => t.IdNumber == user.IdNumber)
            .Select(t => new TeacherDashboardViewModel
            {
                AverageGrade = t.Grades.Average(g => g.GradeValue).ToString("f2"),
                GradesCount = t.Grades.Count,
            })
            .FirstOrDefaultAsync();
        
        return View(model);
    }
}