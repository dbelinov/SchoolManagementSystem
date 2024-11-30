using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface IUserService
{
    Task<bool> AssignToStudentOrTeacherAsync(ApplicationUser user);
    Task<bool> AddToRoleAsync(ApplicationUser user, string role);
}