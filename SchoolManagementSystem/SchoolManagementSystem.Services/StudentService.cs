using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public StudentService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ApplicationUser?> GetLoggedInUserAsync(ClaimsPrincipal user)
        {
            return await _userManager.GetUserAsync(user);
        }

        public async Task<Student?> GetStudentByUserIdAsync(Guid userId)
        {
            return await _context.Students
                .Where(s => s.Id == userId)
                .Include(s => s.Grades)
                .Include(s => s.StudentsProjects)
                .FirstOrDefaultAsync();
        }

        public StudentDashboardViewModel GetDashboardViewModel(Student student)
        {
            var averageGrades = student.Grades.Any()
                ? student.Grades.Average(s => s.GradeValue).ToString("f2")
                : "0.0";

            return new StudentDashboardViewModel
            {
                AverageGrade = averageGrades,
                GradesCount = student.Grades.Count,
                ProjectsCount = student.StudentsProjects.Count,
            };
        }

        public List<StudentGradesViewModel> GetGradesViewModel(Student student)
        {
            return student.Grades
                .GroupBy(sg => sg.Subject)
                .Select(g => new StudentGradesViewModel
                {
                    Subject = g.Key,
                    Grades = g.ToList(),
                })
                .ToList();
        }
    }
}