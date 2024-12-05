using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Seeding;

public class Seeder : ISeeder
{
    public Task SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<School>().HasData(
            new School
            {
                Id = 1,
                Name = "PPMG \"Geo Milev\"",
                Address = "44 Avgusta Trayana\nStara Zagora, Bulgaria",
                Description = "The School of Informatics and Mathematics in Stara Zagora",
                LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD"
            });

        modelBuilder.Entity<Class>().HasData(
            new Class
            {
                Id = 1,
                Name = "9b",
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
            });

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                FirstName = "Mariya",
                MiddleName = "Ivanova",
                LastName = "Petrova",
                IdNumber = "8008089119",
                Subject = Subject.Bulgarian,
            });

        return Task.CompletedTask;
    }
}