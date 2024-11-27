using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Services;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ApplicationDbContext _context;

    public UserService(
        UserManager<ApplicationUser> userManager, 
        SignInManager<ApplicationUser> signInManager, 
        ApplicationDbContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
    }
    
    public async Task<bool> MatchToStudentOrTeacherAsync(ApplicationUser user)
    {
        var studentMatch = _context.Students.FirstOrDefault(s =>
            s.IdNumber == user.IdNumber &&
            s.FirstName == user.FirstName &&
            s.MiddleName == user.MiddleName &&
            s.LastName == user.LastName);

        var teacherMatch = _context.Teachers.FirstOrDefault(t =>
            t.IdNumber == user.IdNumber &&
            t.FirstName == user.FirstName &&
            t.MiddleName == user.MiddleName &&
            t.LastName == user.LastName);

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

        await _userManager.UpdateAsync(user);
        return true;
    }
}