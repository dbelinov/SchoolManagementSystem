using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services;

public class TeacherService : ITeacherService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public TeacherService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<TeacherDashboardViewModel?> GetDashboardAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return null;

        var teacher = await _context.Teachers
            .Include(t => t.Grades)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        if (teacher == null) return null;

        var averageGrades = teacher.Grades.Any(g => g.Subject == teacher.Subject)
            ? teacher.Grades
                .Where(g => g.Subject == teacher.Subject)
                .Average(s => s.GradeValue).ToString("f2")
            : "0.0";

        return new TeacherDashboardViewModel
        {
            AverageGrade = averageGrades,
            GradesCount = teacher.Grades
                .Where(g => g.Subject == teacher.Subject)
                .ToList().Count
        };
    }

    public async Task<TeacherClassesViewModel?> GetGradesDashboardAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return null;

        var teacher = await _context.Teachers
            .Include(t => t.TeachersClasses)
            .ThenInclude(tc => tc.Class)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        if (teacher == null) return null;

        return new TeacherClassesViewModel
        {
            TeacherName = $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}",
            Classes = teacher.TeachersClasses
                .Select(tc => new ClassViewModel
                {
                    Id = tc.ClassId,
                    ClassName = tc.Class.Name
                })
                .ToList()
        };
    }
    
    public async Task<List<TeacherGradesViewModel>?> GetClassGradesAsync(int classId, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return null;

        var teacher = await _context.Teachers
            .Where(t => t.IdNumber == user.IdNumber)
            .Select(t => new
            {
                t.Subject
            })
            .FirstOrDefaultAsync();

        if (teacher == null) return null;

        var studentsInClass = await _context.Students
            .Where(s => s.ClassId == classId)
            .Select(s => new TeacherGradesViewModel
            {
                StudentId = s.Id,
                StudentName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                Grades = s.Grades
                    .Where(g => g.Subject == teacher.Subject)
                    .ToList()
            })
            .ToListAsync();

        return studentsInClass;
    }

    public async Task<int?> AddGradeAsync(int gradeValue, Guid studentId, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return null;

        var teacher = await _context.Teachers
            .Include(t => t.TeachersClasses)
            .FirstOrDefaultAsync(t => t.IdNumber == user.IdNumber);

        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.Id == studentId);

        if (teacher == null || student == null) return null;

        if (teacher.TeachersClasses.Any(tc => tc.ClassId == student.ClassId))
        {
            var grade = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                Subject = teacher.Subject,
                GradeValue = gradeValue
            };

            student.Grades.Add(grade);
            _context.Update(student);
            await _context.SaveChangesAsync();
        }

        return student.ClassId;
    }

    public async Task<int?> DeleteGradeAsync(int gradeId, Guid studentId, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return null;

        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.Id == user.AppId);

        var grade = await _context.Grades.FirstOrDefaultAsync(g => g.Id == gradeId);
        var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == studentId);

        if (grade == null || student == null || teacher == null) return null;

        if (grade.TeacherId == teacher.Id)
        {
            student.Grades.Remove(grade);
            _context.Update(student);
            _context.Remove(grade);
            await _context.SaveChangesAsync();
        }

        return student.ClassId;
    }
}