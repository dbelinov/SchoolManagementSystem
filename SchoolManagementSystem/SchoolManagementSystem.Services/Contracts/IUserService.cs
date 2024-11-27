using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface IUserService
{
    Task<bool> MatchToStudentOrTeacherAsync(ApplicationUser user);
}