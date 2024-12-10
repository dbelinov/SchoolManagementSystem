using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList.Extensions;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area(AdminAreaName)]
[Authorize(Roles = "Admin")]
public class AdminTeachersController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminTeachersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult TeachersList(string searchTerm, int page = 1)
    {
        int pageSize = 10;
        
        var teachersQuery = _context.Teachers
            .AsEnumerable()
            .OrderBy(t => t.FirstName)
            .ThenBy(t => t.MiddleName)
            .ThenBy(t => t.LastName)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            teachersQuery = teachersQuery.Where(t => t.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                                     || t.MiddleName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) 
                                                     || t.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) 
                                                     || t.Subject.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }
        
        var model = teachersQuery
            .Select(t => new TeacherAdminViewModel
            {
                TeacherId = t.Id,
                FullName = $"{t.FirstName} {t.MiddleName} {t.LastName}",
                Subject = t.Subject.ToString(),
                ValidationKey = t.VerificationKey.ToString(),
            })
            .ToPagedList(page, pageSize);
        
        return View(model);
    }
}