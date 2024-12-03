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
    public DbSet<Grade> Grades { get; set; }
    public DbSet<StudentProject> StudentsProjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherClass> TeachersClasses { get; set; }
    public DbSet<Timetable> Timetables { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<School>(e => e.HasData(
            new School
            {
                Id = 1,
                Name = "PPMG \"Geo Milev\"",
                Address = "44 Avgusta Trayana\nStara Zagora, Bulgaria",
                Description = "The School of Informatics and Mathematics in Stara Zagora", 
                LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD"
            }));

        builder.Entity<Class>(e => e.HasData(
                new Class
                {
                    Id = 1,
                    Name = "9b",
                    SchoolId = 1,
                    Speciality = Speciality.ComputerScience,
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
                    Subject = Subject.Bulgarian,
                }
            )
        );
    }
}