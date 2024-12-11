using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
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
    private readonly IUserService _userService;

    public AdminTeachersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IUserService userService)
    {
        _context = context;
        _userManager = userManager;
        _userService = userService;
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
    
    [HttpPost]
    public async Task<IActionResult> DeleteTeacher(Guid id)
    {
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.Id == id);

        if (teacher == null)
        {
            return NotFound();
        }
        
        var teacherUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.AppId == teacher.Id);
        
        _context.Teachers.Remove(teacher);
        await _context.SaveChangesAsync();

        if (teacherUser != null)
        {
            await _userManager.DeleteAsync(teacherUser);
        }
        
        return RedirectToAction(nameof(TeachersList));
    }
    
    [HttpPost]
    public async Task<IActionResult> GenerateValidationKey(Guid id)
    {
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.Id == id);

        if (teacher == null)
        {
            return NotFound();
        }
        
        var newVerificationKey = Guid.NewGuid();
        teacher.VerificationKey = newVerificationKey;
        await _context.SaveChangesAsync();
        
        var teacherUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.AppId == teacher.Id);

        if (teacherUser != null)
        {
            teacherUser.VerificationKey = newVerificationKey;
            await _userManager.UpdateAsync(teacherUser);
        }
        
        return RedirectToAction(nameof(TeachersList));
    }
    
    [HttpGet]
    public async Task<IActionResult> ManageTeacher(Guid id)
    {
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.Id == id);
        
        if (teacher == null) 
        {
            return NotFound();
        }
        
        var model = new TeacherManageViewModel
        {
            FirstName = teacher.FirstName,
            MiddleName = teacher.MiddleName,
            LastName = teacher.LastName,
            Subject = teacher.Subject.ToString(),
            IdNumber = teacher.IdNumber,
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ManageTeacher(Guid id, TeacherManageViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var teacher = await _context.Teachers
            .Include(t => t.TeachersClasses)
            .FirstOrDefaultAsync(t => t.Id == id);

        if (teacher == null)
        {
            return NotFound();
        }
        
        teacher.FirstName = model.FirstName;
        teacher.MiddleName = model.MiddleName;
        teacher.LastName = model.LastName;
        teacher.Subject = Enum.Parse<Subject>(model.Subject);
        teacher.IdNumber = model.IdNumber;
        
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(TeachersList));
    }

    [HttpGet]
    public async Task<IActionResult> CreateTeacher()
    {
        var model = new TeacherCreateViewModel
        {
            Schools = await _context.Schools
                .Select(s => new SchoolSelectViewModel
                {
                    SchoolId = s.Id,
                    Name = s.Name
                }).ToListAsync(),
        };
        
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTeacher(TeacherCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var teacher = new Teacher
        {
            FirstName = model.FirstName,
            MiddleName = model.MiddleName,
            LastName = model.LastName,
            Subject = Enum.Parse<Subject>(model.Subject),
            IdNumber = model.IdNumber
        };
        
        _context.Teachers.Add(teacher);
        await _context.SaveChangesAsync();

        var classNames = model.Classes.Split(", ");
        
        var school = await _context.Schools
            .Include(school => school.Classes)
            .FirstOrDefaultAsync(s => s.Id == model.SchoolId);
        
        if (school == null)
        {
            return BadRequest();
        }
        
        var teacherClasses = new List<TeacherClass>();
        foreach (var classString in classNames)
        {
            var classEntity = school.Classes
                .FirstOrDefault(c => c.Name == classString);

            if (classEntity is null)
            {
                ModelState.AddModelError(string.Empty, classString);
                return View(model);
            }

            var teacherClass = new TeacherClass
            {
                TeacherId = teacher.Id,
                ClassId = classEntity.Id,
            };
            teacherClasses.Add(teacherClass);
        }
        
        _context.TeachersClasses.AddRange(teacherClasses);
        await _context.SaveChangesAsync();
        
        var alreadySignedUpUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.IdNumber == model.IdNumber 
                                      && u.FirstName == model.FirstName
                                      && u.MiddleName == model.MiddleName
                                      && u.LastName == model.LastName);

        if (alreadySignedUpUser != null)
        {
            await _userService.AssignToStudentOrTeacherAsync(alreadySignedUpUser);
        }
        
        return RedirectToAction(nameof(TeachersList));
    }
}