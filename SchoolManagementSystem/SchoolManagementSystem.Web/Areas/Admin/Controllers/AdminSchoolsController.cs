using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList.Extensions;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class AdminSchoolsController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminSchoolsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult SchoolsList(string searchTerm, int page = 1)
    {
        int pageSize = 10;
        
        var schoolsQuery = _context.Schools
            .OrderBy(s => s.Name)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            schoolsQuery = schoolsQuery.Where(s => s.Name.Contains(searchTerm)
                                                     || s.Address.Contains(searchTerm));
        }
        
        var model = schoolsQuery
            .Select(s => new SchoolsAdminViewModel
            {
                SchoolId = s.Id,
                Address = s.Address,
                SchoolName = s.Name,
                Classes = s.Classes.Count
            })
            .ToPagedList(page, pageSize);
        
        return View(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteSchool(int id)
    {
        var school = await _context.Schools
            .FirstOrDefaultAsync(s => s.Id == id);

        if (school == null)
        {
            return NotFound();
        }
        
        _context.Schools.Remove(school);
        
        var schoolClasses = _context.Classes
            .Where(c => c.SchoolId == id);

        _context.Classes.RemoveRange(schoolClasses);
        
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(SchoolsList));
    }

    [HttpGet]
    public async Task<IActionResult> AddClass(int schoolId)
    {
        var school = await _context.Schools
            .FirstOrDefaultAsync(s => s.Id == schoolId);

        if (school == null)
        {
            return NotFound();
        }

        var viewModel = new ClassAddViewModel
        {
            SchoolId = schoolId,
        };

        return View(viewModel);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddClass(ClassAddViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var newClass = new Class
        {
            Name = model.Name,
            Speciality = Enum.Parse<Speciality>(model.Speciality),
            SchoolId = model.SchoolId,
        };
        
        _context.Classes.Add(newClass);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(SchoolsList));
    }
}