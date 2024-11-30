using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers
{
    [Authorize]
    public class VerificationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IVerificationService _verificationService;

        public VerificationController(
            UserManager<ApplicationUser> userManager,
            IVerificationService verificationService)
        {
            _userManager = userManager;
            _verificationService = verificationService;
        }
        
        [HttpGet]
        public async Task<IActionResult> VerificationCodeEntry()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user is not null && user.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerificationCodeEntry(VerificationEntryViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user is null)
            {
                ModelState.AddModelError("user", NotLoggedIn);
                return View(model);
            }

            var isVerified = await _verificationService.VerifyCodeAsync(user, model.VerificationKey);

            if (!isVerified)
            {
                ModelState.AddModelError("VerificationKey", InvalidValidationKey);
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}