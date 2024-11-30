using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers;

public class UserController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserService _userService;
    public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, 
        IUserService userService)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _userService = userService;
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
        
        bool birthDateValid = DateTime.TryParse(model.BirthDate, out DateTime validBirthDate);

        if (!birthDateValid)
        {
            ModelState.AddModelError(nameof(model.BirthDate), InvalidBirthDate);
            return View(model);
        }
        
        ApplicationUser user = new ApplicationUser()
        {
            IdNumber = model.IdNumber,
            FirstName = model.FirstName,
            MiddleName = model.MiddleName,
            LastName = model.LastName,
            BirthDate = validBirthDate,
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

            return View(model);
        }

        user.IsGuest = !await _userService.AssignToStudentOrTeacherAsync(user);
        await _userManager.UpdateAsync(user);
        
        await _signInManager.SignInAsync(user, false);
        
        return RedirectToAction("Index", "Home");
    }
}