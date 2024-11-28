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
                .Include(student => student.StudentGrades)
                .Include(student => student.StudentsProjects)
                .FirstOrDefaultAsync(s => s.Id == userId);
        }

        public StudentDashboardViewModel GetDashboardViewModel(Student student)
        {
            var averageGrades = student.StudentGrades.Any()
                ? student.StudentGrades.Average(s => s.Grade).ToString("f2")
                : "0.0";

            return new StudentDashboardViewModel
            {
                AverageGrade = averageGrades,
                GradesCount = student.StudentGrades.Count,
                ProjectsCount = student.StudentsProjects.Count,
            };
        }

        public List<StudentGradesViewModel> GetGradesViewModel(Student student)
        {
            return student.StudentGrades
                .GroupBy(sg => sg.Subject)
                .Select(g => new StudentGradesViewModel
                {
                    Subject = g.Key,
                    Grades = g.ToList()
                })
                .ToList();
        }
    }
}