using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;

namespace SchoolManagementSystem.Services;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;
    private readonly ApplicationDbContext _context;

    public UserService(
        UserManager<ApplicationUser> userManager, 
        RoleManager<IdentityRole<Guid>> roleManager,
        ApplicationDbContext context)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
    }
    
    public async Task<bool> AssignToStudentOrTeacherAsync(ApplicationUser user)
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
            await _userManager.AddToRoleAsync(user, nameof(Student));
        }
        else if (teacherMatch is not null)
        {
            user.AppId = teacherMatch.Id;
            user.VerificationKey = teacherMatch.VerificationKey;
            await _userManager.AddToRoleAsync(user, nameof(Teacher));
        }

        await _userManager.UpdateAsync(user);
        return true;
    }
    
    public async Task<bool> AddToRoleAsync(ApplicationUser user, string roleName)
    {
        bool roleExists = await _roleManager.RoleExistsAsync(roleName);
        
        if (!roleExists)
        {
            var role = new IdentityRole<Guid>(roleName);
            await _roleManager.CreateAsync(role);
        }

        var result = await _userManager.AddToRoleAsync(user, roleName);

        if (result.Succeeded)
        {
            return true;
        }

        return false;
    }
}