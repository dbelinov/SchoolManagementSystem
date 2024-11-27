using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.Views;

namespace SchoolManagementSystem.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;

    public HomeController(ILogger<HomeController> logger, 
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole<Guid>> roleManager)
    {
        _logger = logger;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        if (user?.IsGuest is true)
        {
            return View();
        }
        
        if (user?.IsAuthenticated is false)
        {
            return RedirectToAction("VerificationCodeEntry", "Verification");
        }

        if(user != null && await _userManager.IsInRoleAsync(user, nameof(Student)))
        {
            return RedirectToAction("Dashboard", "Student");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}