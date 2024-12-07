using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;

namespace SchoolManagementSystem.Web.Controllers;

[Authorize(Roles = nameof(Teacher))]
[ValidateAntiForgeryToken]
public class TeacherController : Controller
{
    private readonly ITeacherService _teacherService;
    private readonly UserManager<ApplicationUser> _userManager;

    public TeacherController(ITeacherService teacherService, UserManager<ApplicationUser> userManager)
    {
        _teacherService = teacherService;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Dashboard()
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetDashboardAsync(userId);

        if (model == null)
        {
            return RedirectToAction("Index", "Home");
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> GradesDashboard()
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetGradesDashboardAsync(userId);

        if (model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> ClassGrades(int classId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var model = await _teacherService.GetClassGradesAsync(classId, userId);

        if (model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> AddGrade(int gradeValue, Guid studentId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var success = await _teacherService.AddGradeAsync(gradeValue, studentId, userId);

        if (success is null)
        {
            return BadRequest();
        }

        return RedirectToAction("ClassGrades", "Teacher", new { classId = success });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteGrade(int gradeId, Guid studentId)
    {
        var userId = _userManager.GetUserId(User);
        
        if (userId == null) return BadRequest();
        
        var success = await _teacherService.DeleteGradeAsync(gradeId, studentId, userId);

        if (success is null)
        {
            return BadRequest();
        }

        return RedirectToAction("ClassGrades", "Teacher", new { classId = success });
    }
}