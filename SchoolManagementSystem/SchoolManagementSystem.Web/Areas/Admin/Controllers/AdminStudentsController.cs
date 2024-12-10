using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class AdminStudentsController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminStudentsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> StudentsList()
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

    [HttpPost]
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
    public async Task<IActionResult> GenerateValidationKey(Guid id)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == id);

        if (student == null)
        {
            return BadRequest();
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
}