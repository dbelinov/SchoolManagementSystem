using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Web.Controllers;

public class UserController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        ApplicationUser user = new ApplicationUser()
        {
            IdNumber = model.IdNumber,
            FirstName = model.FirstName,
            MiddleName = model.MiddleName,
            LastName = model.LastName,
        };

        await _userManager.SetEmailAsync(user, model.Email);
        await _userManager.SetUserNameAsync(user, model.Email);

        IdentityResult? result = await _userManager.CreateAsync(user, model.Password);

        if (!result.Succeeded)
        {
            foreach (IdentityError modelError in result.Errors)
            {
                ModelState.AddModelError(string.Empty, modelError.Description);
            }

            return View(model); // return view with error messages if user creation fails
        }

        await _signInManager.SignInAsync(user, false);
        return RedirectToAction("Index", "Home");
    }
}