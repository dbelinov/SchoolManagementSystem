using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using System;
using System.Security.Claims;

namespace SchoolManagementSystem.Services
{
    public class VerificationService : IVerificationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserService _userService;

        public VerificationService(UserManager<ApplicationUser> userManager, IUserService userService, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _userService = userService;
            _signInManager = signInManager;
        }

        public async Task<bool> VerifyCodeAsync(ApplicationUser? user, string verificationKey)
        {
            if (user is null || string.IsNullOrWhiteSpace(verificationKey))
            {
                return false;
            }

            if (!Guid.TryParse(verificationKey, out Guid validGuid))
            {
                return false;
            }

            if (user.VerificationKey != validGuid)
            {
                return false;
            }

            user.IsAuthenticated = true;
            await _userManager.AddClaimAsync(user, new Claim("Authenticated", "true"));
            var result = await _userManager.UpdateAsync(user);

            return result.Succeeded;
        }
    }
}