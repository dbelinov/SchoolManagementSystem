using System.Security.Claims;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface IStudentService
{
    Task<ApplicationUser?> GetLoggedInUserAsync(ClaimsPrincipal user);
    Task<Student?> GetStudentByUserIdAsync(Guid userId);
    StudentDashboardViewModel GetDashboardViewModel(Student student);
    List<StudentGradesViewModel> GetGradesViewModel(Student student);
}