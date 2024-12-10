using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area(AdminAreaName)]
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult Dashboard()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> ManageStudents()
    {
        var model = await _context.Students
            .OrderBy(s => s.FirstName)
            .ThenBy(s => s.MiddleName)
            .ThenBy(s => s.LastName)
            .Select(s => new StudentAdminViewModel
            {
                StudentId = s.Id,
                FullName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                ClassName = s.Class.Name,
                ValidationKey = s.VerificationKey.ToString(),
            })
            .ToListAsync();
        
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> ManageStudent(Guid id)
    {
        var student = _context.Students
            .FirstOrDefault(s => s.Id == id);

        return View();
    }
}