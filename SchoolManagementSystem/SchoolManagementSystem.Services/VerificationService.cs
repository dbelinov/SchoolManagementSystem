using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using System;

namespace SchoolManagementSystem.Services
{
    public class VerificationService : IVerificationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;

        public VerificationService(UserManager<ApplicationUser> userManager, IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
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
            var result = await _userManager.UpdateAsync(user);

            return result.Succeeded;
        }
    }
}