using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList.Extensions;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class AdminProjectsController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminProjectsController(ApplicationDbContext context)
    {
        _context = context;
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

    public IActionResult ProjectsList(int schoolId, string searchTerm, int page = 1)
    {
        int pageSize = 10;
        
        var projectsQuery = _context.Projects
            .Where(p => p.SchoolsProjects.Any(sp => sp.SchoolId == schoolId))
            .OrderBy(p => p.Name)
            .AsQueryable();
        
        if (!string.IsNullOrEmpty(searchTerm))
        {
            projectsQuery = projectsQuery.Where(p => p.Name.Contains(searchTerm));
        }
        
        var projects = projectsQuery
            .Select(p => new ProjectAdminViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Capacity = p.Capacity,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                SchoolId = schoolId,
            }).ToPagedList(page, pageSize);

        return View(projects);
    }

    [HttpGet]
    public async Task<IActionResult> CreateProject(int schoolId)
    {
        return View(new ProjectCreateViewModel());
    }
}