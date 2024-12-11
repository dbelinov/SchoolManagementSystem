using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.Views;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Controllers;

public class HomeController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        if (user?.IsGuest is true)
        {
            return RedirectToAction("Schools", "School");
        }
        
        if (user?.IsAuthenticated is false)
        {
            return RedirectToAction("VerificationCodeEntry", "Verification");
        }

        if(user != null && await _userManager.IsInRoleAsync(user, nameof(Student)))
        {
            return RedirectToAction("Dashboard", "Student");
        }

        if (user != null && await _userManager.IsInRoleAsync(user, nameof(Teacher)))
        {
            return RedirectToAction("Dashboard", "Teacher");
        }

        if (user != null && await _userManager.IsInRoleAsync(user, AdminRoleName))
        {
            return RedirectToAction("Index", "Admin", new { area = "Admin" });
        }
        
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    public IActionResult Error404()
    {
        return View();
    }
}