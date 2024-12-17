using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Data.Seeding;

namespace SchoolManagementSystem.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Class> Classes { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<School> Schools { get; set; }
    public DbSet<SchoolProject> SchoolsProjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<StudentProject> StudentsProjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherClass> TeachersClasses { get; set; }
    public DbSet<Timetable> Timetables { get; set; }
}