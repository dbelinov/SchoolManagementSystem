using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList.Extensions;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

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

    [HttpGet]
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
                StartDate = p.StartDate.ToString(DateFormat),
                EndDate = p.EndDate.ToString(DateFormat),
                SchoolId = schoolId
            }).ToPagedList(page, pageSize);

        return View(projects);
    }

    [HttpGet]
    public async Task<IActionResult> CreateProject(int schoolId)
    {
        var availableProjects = await _context.Projects
            .Select(p => new ProjectAdminViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Capacity = p.Capacity,
                StartDate = p.StartDate.ToString(DateFormat),
                EndDate = p.EndDate.ToString(DateFormat),
                SchoolId = schoolId
            })
            .ToListAsync();
        return View(new ProjectCreateViewModel { AvailableProjects = availableProjects });
    }

    public async Task<IActionResult> CreateProject(int schoolId, ProjectCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        Project project = new Project
        {
            Name = model.Name,
            Capacity = model.Capacity,
            StartDate = model.StartDate,
            EndDate = model.EndDate,
        };
        
        await _context.Projects.AddAsync(project);
        await _context.SaveChangesAsync();

        var schoolProject = new SchoolProject
        {
            SchoolId = schoolId,
            ProjectId = project.Id,
        };
        
        await _context.SchoolsProjects.AddAsync(schoolProject);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(ProjectsList), new { schoolId });
    }

    public async Task<IActionResult> AddProject(int schoolId, int projectId)
    {
        return View();
    }
}