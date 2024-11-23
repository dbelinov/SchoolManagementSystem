using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers;

public class UserController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, 
        ApplicationDbContext context)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _context = context;
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
        
        var isValidUser = MatchToStudentOrTeacher(user);
        if (!isValidUser)
        {
            ModelState.AddModelError(nameof(model.BirthDate), InvalidUser);
            return View(model);
        }
        
        await _signInManager.SignInAsync(user, false);
        
        return RedirectToAction("Index", "Home");
    }

    private bool MatchToStudentOrTeacher(ApplicationUser user)
    {
        var studentMatch = _context.Students.FirstOrDefault(s => s.IdNumber == user.IdNumber 
                                                                 && s.FirstName == user.FirstName 
                                                                 && s.MiddleName == user.MiddleName 
                                                                 && s.LastName == user.LastName);
        
        var teacherMatch = _context.Teachers.FirstOrDefault(t => t.IdNumber == user.IdNumber 
                                                                 && t.FirstName == user.FirstName 
                                                                 && t.MiddleName == user.MiddleName 
                                                                 && t.LastName == user.LastName);

        if (studentMatch is null && teacherMatch is null)
        {
            return false;
        }

        if (studentMatch is not null)
        {
            user.AppId = studentMatch.Id;
            user.VerificationKey = studentMatch.VerificationKey;
        }
        else if (teacherMatch is not null)
        {
            user.AppId = teacherMatch.Id;
            user.VerificationKey = teacherMatch.VerificationKey;
        }

        user.IsGuest = false;
        _userManager.UpdateAsync(user);

        return true;
    }
}