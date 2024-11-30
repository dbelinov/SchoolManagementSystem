using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;

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
    public DbSet<StudentGrade> StudentsGrades { get; set; }
    public DbSet<StudentProject> StudentsProjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherClass> TeachersClasses { get; set; }
    public DbSet<Timetable> Timetables { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Class>(e => e.HasData(
                new Class
                {
                    Id = 1,
                    Name = "9b",
                    Speciality = Speciality.ComputerScience
                })
        );
        
        builder.Entity<Student>(e => e.HasData(
                new Student { 
                    FirstName = "Ivan", 
                    MiddleName = "Ivanov", 
                    LastName = "Ivanov", 
                    IdNumber = "0141012442",
                    ClassId = 1
                })
        );
        
        builder.Entity<Student>(e => e.HasData(
            new Student { 
                FirstName = "Gencho", 
                MiddleName = "Petkov", 
                LastName = "Ginev", 
                IdNumber = "0543121244",
                ClassId = 1
            })
        );

        builder.Entity<Teacher>(e => e
            .HasData(
                new Teacher
                {
                    FirstName = "Mariya",
                    MiddleName = "Ivanova",
                    LastName = "Petrova",
                    IdNumber = "8008089119",
                    Subject = Subject.Bulgarian
                }
            )
        );
    }
}