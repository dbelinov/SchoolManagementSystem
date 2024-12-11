using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services;

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
            .Include(s => s.Class)
            .ThenInclude(c => c.School)
            .ThenInclude(s => s.SchoolsProjects)
            .ThenInclude(sp => sp.Project)
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
            ProjectsCount = student.StudentsProjects.Count
        };
    }

    public List<StudentGradesViewModel> GetGradesViewModel(Student student)
    {
        return student.Grades
            .GroupBy(sg => sg.Subject)
            .Select(g => new StudentGradesViewModel
            {
                Subject = g.Key,
                Grades = g.ToList()
            })
            .ToList();
    }

    public async Task<StudentProjectsViewModel?> GetStudentProjectsAsync(ClaimsPrincipal user)
    {
        var appUser = await GetLoggedInUserAsync(user);
        if (appUser is null)
            return null;

        var student = await GetStudentByUserIdAsync(appUser.AppId);
        if (student is null)
            return null;

        var studentSchool = await _context.Schools
            .Include(s => s.SchoolsProjects)
            .ThenInclude(sp => sp.Project)
            .ThenInclude(p => p.StudentsProjects)
            .FirstOrDefaultAsync(s => s.Id == student.Class.SchoolId);

        if (studentSchool is null)
            return null;

        var databaseProjects = studentSchool.SchoolsProjects.ToList();

        var allProjects = databaseProjects
            .Where(sp => sp.Project.StudentsProjects.Count + 1 <= sp.Project.Capacity)
            .Select(sp => new ProjectViewModel
            {
                Id = sp.ProjectId,
                Name = sp.Project.Name
            })
            .ToList();

        var userProjects = databaseProjects
            .Where(sp => sp.Project.StudentsProjects.Any(s => s.StudentId == student.Id))
            .Select(sp => new ProjectViewModel
            {
                Id = sp.ProjectId,
                Name = sp.Project.Name
            })
            .ToList();

        return new StudentProjectsViewModel
        {
            AllProjects = allProjects,
            UserProjects = userProjects
        };
    }

    public async Task<bool> JoinProjectAsync(ClaimsPrincipal user, int projectId)
    {
        var appUser = await GetLoggedInUserAsync(user);
        if (appUser is null)
            return false;

        var student = await GetStudentByUserIdAsync(appUser.AppId);
        if (student is null)
            return false;

        var project = await _context.Projects
            .Include(p => p.StudentsProjects)
            .FirstOrDefaultAsync(p => p.Id == projectId);

        if (project == null || project.StudentsProjects.Count >= project.Capacity)
            return false;

        var studentProject = new StudentProject
        {
            StudentId = student.Id,
            ProjectId = projectId
        };

        project.StudentsProjects.Add(studentProject);
        student.StudentsProjects.Add(studentProject);

        await _context.StudentsProjects.AddAsync(studentProject);
        _context.Update(project);
        _context.Update(student);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> LeaveProjectAsync(ClaimsPrincipal user, int projectId)
    {
        var appUser = await GetLoggedInUserAsync(user);
        if (appUser is null)
            return false;

        var student = await GetStudentByUserIdAsync(appUser.AppId);
        if (student is null)
            return false;

        var project = await _context.Projects
            .Include(p => p.StudentsProjects)
            .FirstOrDefaultAsync(p => p.Id == projectId);

        if (project == null)
            return false;

        var studentProject = project.StudentsProjects
            .FirstOrDefault(sp => sp.StudentId == student.Id);

        if (studentProject == null)
            return false;

        project.StudentsProjects.Remove(studentProject);
        student.StudentsProjects.Remove(studentProject);

        _context.StudentsProjects.Remove(studentProject);
        _context.Update(project);
        _context.Update(student);
        await _context.SaveChangesAsync();

        return true;
    }
}