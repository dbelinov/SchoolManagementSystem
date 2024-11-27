using SchoolManagementSystem.Data.Models.IdentityModels;

namespace SchoolManagementSystem.Services.Contracts
{
    public interface IVerificationService
    {
        Task<bool> VerifyCodeAsync(ApplicationUser user, string verificationKey);
    }
}