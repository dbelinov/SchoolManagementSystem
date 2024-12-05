using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;

namespace SchoolManagementSystem.Data.Seeding;

public class Seeder : ISeeder
{
    public Task SeedData(ModelBuilder modelBuilder)
    {
        var teacher1Id = Guid.NewGuid();
        var teacher2Id = Guid.NewGuid();
        
        modelBuilder.Entity<School>().HasData(
            new School
            {
                Id = 1,
                Name = "PPMG \"Geo Milev\"",
                Address = "44 Avgusta Trayana\nStara Zagora, Bulgaria",
                Description = "The School of Informatics and Mathematics in Stara Zagora",
                LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD",
            });

        modelBuilder.Entity<Class>().HasData(
            new Class
            {
                Id = 1,
                Name = "9b",
                SchoolId = 1,
                Speciality = Speciality.ComputerScience,
            },
            new Class
            {
                Id = 2,
                Name = "10b",
                SchoolId = 1,
                Speciality = Speciality.ComputerScience,
            });

        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                FirstName = "Ivan",
                MiddleName = "Ivanov",
                LastName = "Ivanov",
                IdNumber = "0141012442",
                ClassId = 1
            },
            new Student
            {
                FirstName = "Gencho",
                MiddleName = "Petkov",
                LastName = "Ginev",
                IdNumber = "0543121244",
                ClassId = 1
            },
            new Student()
            {
                FirstName = "Martin",
                MiddleName = "Ivanov",
                LastName = "Georgiev",
                IdNumber = "0741124324",
                ClassId = 2
            });

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                Id = teacher1Id,
                FirstName = "Maria",
                MiddleName = "Ivanova",
                LastName = "Petrova",
                IdNumber = "8008089119",
                Subject = Subject.Bulgarian,
            },
            new Teacher()
            {
                Id = teacher2Id,
                FirstName = "Stefka",
                MiddleName = "Petkova",
                LastName = "Gineva",
                IdNumber = "9003021331",
                Subject = Subject.German
            });

        modelBuilder.Entity<TeacherClass>().HasData(
            new TeacherClass
            {
                ClassId = 1,
                TeacherId = teacher1Id,
            },
            new TeacherClass
            {
                ClassId = 2,
                TeacherId = teacher1Id
            },
            new TeacherClass
            {
                ClassId = 1,
                TeacherId = teacher2Id,
            },
            new TeacherClass
            {
                ClassId = 2,
                TeacherId = teacher2Id
            });
        
        SeedAdmin(modelBuilder).Wait();

        return Task.CompletedTask;
    }

    private static Task SeedAdmin(ModelBuilder modelBuilder)
    {
        var roleId = Guid.NewGuid();
        
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(
            new IdentityRole<Guid>
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

        var adminId = Guid.NewGuid();

        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = adminId,
                VerificationKey = adminId,
                AppId = adminId,
                UserName = "admin@scholario.com",
                NormalizedUserName = "ADMIN@SCHOLARIO.COM",
                Email = "admin@scholario.com",
                NormalizedEmail = "ADMIN@SCHOLARIO.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Admin",
                MiddleName = "Adminov",
                LastName = "Adminov",
                IdNumber = "2452064114",
                BirthDate = DateTime.Now,
                IsAuthenticated = true,
                IsGuest = false
            });
        
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = adminId,
                RoleId = roleId
            });
        
        return Task.CompletedTask;
    }
}