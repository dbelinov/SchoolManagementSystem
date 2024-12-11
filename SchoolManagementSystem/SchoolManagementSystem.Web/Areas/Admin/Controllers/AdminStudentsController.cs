using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList.Extensions;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area(AdminAreaName)]
[Authorize(Roles = "Admin")]
public class AdminStudentsController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserService _userService;

    public AdminStudentsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IUserService userService)
    {
        _context = context;
        _userManager = userManager;
        _userService = userService;
    }

    [HttpGet]
    public IActionResult StudentsList(string searchTerm, int page = 1)
    {
        int pageSize = 10;
        
        var studentsQuery = _context.Students
            .OrderBy(s => s.FirstName)
            .ThenBy(s => s.MiddleName)
            .ThenBy(s => s.LastName)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            studentsQuery = studentsQuery.Where(s => s.FirstName.Contains(searchTerm)
            || s.MiddleName.Contains(searchTerm) || s.LastName.Contains(searchTerm) || s.Class.Name.Contains(searchTerm)
            || s.Class.School.Name.Contains(searchTerm));
        }
        
        var model = studentsQuery
            .Select(s => new StudentAdminViewModel
            {
                StudentId = s.Id,
                FullName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                SchoolName = s.Class.School.Name,
                ClassName = s.Class.Name,
                ValidationKey = s.VerificationKey.ToString(),
            })
            .ToPagedList(page, pageSize);
        
        return View(model);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeleteStudent(Guid id)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id);

        if (student == null)
        {
            return BadRequest();
        }
        
        var studentUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.AppId == student.Id);
        
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        if (studentUser != null)
        {
            await _userManager.DeleteAsync(studentUser);
        }
        
        return RedirectToAction(nameof(StudentsList));
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> GenerateValidationKey(Guid id)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id);

        if (student == null)
        {
            return NotFound();
        }
        
        var newVerificationKey = Guid.NewGuid();
        student.VerificationKey = newVerificationKey;
        await _context.SaveChangesAsync();
        
        var studentUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.AppId == student.Id);

        if (studentUser != null)
        {
            studentUser.VerificationKey = newVerificationKey;
            await _userManager.UpdateAsync(studentUser);
        }
        
        return RedirectToAction(nameof(StudentsList));
    }

    [HttpGet]
    public async Task<IActionResult> ManageStudent(Guid id)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id);
        
        if (student == null) 
        {
            return BadRequest();
        }

        var model = new StudentManageViewModel
        {
            FirstName = student.FirstName,
            MiddleName = student.MiddleName,
            LastName = student.LastName,
            IdNumber = student.IdNumber,
        };

        return View(model);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> ManageStudent(Guid id, StudentManageViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id);

        if (student == null)
        {
            return BadRequest();
        }
        
        student.FirstName = model.FirstName;
        student.MiddleName = model.MiddleName;
        student.LastName = model.LastName;
        student.IdNumber = model.IdNumber;
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
        
        var studentUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.AppId == student.Id);

        if (studentUser != null)
        {
            studentUser.FirstName = model.FirstName;
            studentUser.MiddleName = model.MiddleName;
            studentUser.LastName = model.LastName;
            studentUser.IdNumber = model.IdNumber;
            await _userManager.UpdateAsync(studentUser);
        }
        
        return RedirectToAction(nameof(StudentsList));
    }

    [HttpGet]
    public async Task<IActionResult> CreateStudent()
    {
        var model = new StudentCreateViewModel
        {
            Schools = await _context.Schools
                .Select(s => new SchoolSelectViewModel
                {
                    SchoolId = s.Id,
                    Name = s.Name
                }).ToListAsync()
        };
        
        return View(model);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetClassesForSchool(int schoolId)
    {
        var classes = await _context.Classes
            .Where(c => c.SchoolId == schoolId)
            .Select(c => new
            {
                c.Id,
                c.Name
            }).ToListAsync();

        return Json(classes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStudent(StudentCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            model.Schools = await _context.Schools
                .Select(s => new SchoolSelectViewModel
                {
                    SchoolId = s.Id,
                    Name = s.Name
                }).ToListAsync();
            
            return View(model);
        }

        var student = new Student
        {
            FirstName = model.FirstName,
            MiddleName = model.MiddleName,
            LastName = model.LastName,
            IdNumber = model.IdNumber,
            ClassId = model.ClassId
        };
        
        _context.Students.Add(student);
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
        
        return RedirectToAction(nameof(StudentsList));
    }
}