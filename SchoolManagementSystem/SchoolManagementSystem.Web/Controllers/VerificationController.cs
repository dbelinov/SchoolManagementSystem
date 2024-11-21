using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Web.Controllers;

public class VerificationController : Controller
{
    //private readonly IVerificationService _verificationService;
    private readonly UserManager<ApplicationUser> _userManager;

    public VerificationController(UserManager<ApplicationUser> userManager/*, IVerificationService verificationService*/)
    {
        _userManager = userManager;
      //  _verificationService = verificationService;
    }
    
    [HttpGet]
    public IActionResult VerificationCodeEntry()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> VerificationCodeEntry(VerificationEntryViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _userManager.GetUserAsync(HttpContext.User);

        if (user is null)
        {
            ModelState.AddModelError("user", "Mot logged in");
            return View(model);
        }
        
        var keyAsGuid = Guid.TryParse(model.VerificationKey, out Guid validGuid);

        if (!keyAsGuid)
        {
            ModelState.AddModelError("VerificationKey", "Verification key is invalid");
        }
        
        if (user.VerificationKey == validGuid)
        {
            user.IsAuthenticated = true;
            await _userManager.UpdateAsync(user);
        }
        
        return RedirectToAction("Index", "Home");
    }
}