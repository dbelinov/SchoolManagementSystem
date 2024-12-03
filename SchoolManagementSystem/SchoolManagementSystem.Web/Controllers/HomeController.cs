using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.Views;

namespace SchoolManagementSystem.Web.Controllers;

public class HomeController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHomeService _homeService;

    public HomeController(UserManager<ApplicationUser> userManager,
        IHomeService homeService)
    {
        _userManager = userManager;
        _homeService = homeService;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(HttpContext.User);

        if (user?.IsGuest is true)
        {
            return RedirectToAction("LoggedIndex");
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
        
        return View();
    }

    public async Task<IActionResult> LoggedIndex() 
        => View(await _homeService.GetAllSchoolsAsync());
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}