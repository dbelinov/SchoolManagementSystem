using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;

namespace SchoolManagementSystem.Data.Seeding;

public class Seeder : ISeeder
{
    //Already matches profiles with existing people:
    //Students -> Ivan, Gencho, Martin, Ginka, Jivko, Pencho
    
    //Users available for registration testing:
    //Students -> Diana, Ruzha
    
    //All teachers are matched with profiles
    //Maria, Stefka, Stamen, Stoyanka, Petar, Boncho
    
    //Email template used: firstname@gmail.com
    //Password used: Parola123
    
    public Task SeedData(ModelBuilder modelBuilder)
    {
        //Teachers School 1
        var teacherMariaId = Guid.NewGuid();
        var teacherStefkaId = Guid.NewGuid();
        var teacherStamenId = Guid.NewGuid();
        
        //Students School 1
        var studentIvanId = Guid.NewGuid();
        var studentGenchoId = Guid.NewGuid();
        var studentMartinId = Guid.NewGuid();
        var studentGinkaId = Guid.NewGuid();
        
        //Teachers School 2
        var teacherStoyankaId = Guid.NewGuid();
        var teacherPetarId = Guid.NewGuid();
        var teacherBonchoId = Guid.NewGuid();
        
        //Students School 2
        var studentJivkoId = Guid.NewGuid();
        var studentPenchoId = Guid.NewGuid();
        var studentDianaId = Guid.NewGuid();
        var studentRuzhaId = Guid.NewGuid();
        
        //User VerificationCodes
        var mariaVerificationCode = Guid.NewGuid();
        var stefkaVerificationCode = Guid.NewGuid();
        var stamenVerificationCode = Guid.NewGuid();
        
        var ivanVerificationCode = Guid.NewGuid();
        var genchoVerificationCode = Guid.NewGuid();
        var martinVerificationCode = Guid.NewGuid();
        var ginkaVerificationCode = Guid.NewGuid();
        
        var stoyankaVerificationCode = Guid.NewGuid();
        var petarVerificationCode = Guid.NewGuid();
        var bonchoVerificationCode = Guid.NewGuid();
        
        var jivkoVerificationCode = Guid.NewGuid();
        var penchoVerificationCode = Guid.NewGuid();
        
        //Schools
        modelBuilder.Entity<School>().HasData(
            new School
            {
                Id = 1,
                Name = "PPMG \"Geo Milev\"",
                Address = "Avgusta Trayana 44, Stara Zagora, Bulgaria",
                Description = "The School of Informatics and Mathematics in Stara Zagora",
                LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t39.30808-6/327026697_887516432673344_8690934784557383737_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=Rr0iH229ZRwQ7kNvgFeKEcF&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AizPmB3yiG6QTT84Mh5cpaJ&oh=00_AYDekshXGVy2Xa02RxZHINhma0rvygf0uH2D2_cO5om7Dg&oe=675539CD",
               // Specialities = new List<Speciality>{Speciality.ComputerScience, Speciality.Mathematics, Speciality.Medicine}
            },
            new School
            {
                Id = 2,
                Name = "SSFL \"Romain Rolland\"",
                Address = "Tsar Ivan Shishman 62, Stara Zagora, Bulgaria",
                Description = "Stara Zagora's School for Languages like German, French and English",
                LogoUrl = "https://scontent.fsof1-2.fna.fbcdn.net/v/t1.6435-9/119450239_3343706645698457_6833144760730823616_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=ydzqvT5knjIQ7kNvgHdpGNw&_nc_zt=23&_nc_ht=scontent.fsof1-2.fna&_nc_gid=AFu1voqShMlHBNalgqkJBc1&oh=00_AYCyzp4BZ7gcXj6ZSnpr1Oop6AQoeJAI-BKPdIUJsGXD5Q&oe=677BAAFA",
                //Specialities = new List<Speciality>{Speciality.German, Speciality.French, Speciality.English}
            },
            new School
            {
                Id = 3,
                Name = "Technical University of Sofia",
                Address = "Sveti Kliment Ohridski 8, Sofia, Bulgaria",
                Description = "The Technical University of Sofia is Bulgaria's largest and foremost academic establishment for higher engineering education.",
                LogoUrl = "https://scontent.fsof1-1.fna.fbcdn.net/v/t39.30808-6/453179855_1108969364009343_5412650960044976974_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=qPhfwrpLKZUQ7kNvgGHjtnI&_nc_zt=23&_nc_ht=scontent.fsof1-1.fna&_nc_gid=A1xPbdI_kb_P2-V2ZeYF9Ij&oh=00_AYCD4-wxXkM0nUjRh1A3Z58xa9vtxRdQAf4fh6OnOsLa_g&oe=675A5DED",
               // Specialities = new List<Speciality> { Speciality.Mathematics, Speciality.ComputerScience}
            });

        //Classes
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
            },
            new Class
            {
                Id = 3,
                Name = "8g",
                SchoolId = 1,
                Speciality = Speciality.Mathematics
            },
            new Class
            {
                Id = 4,
                Name = "10a",
                SchoolId = 2,
                Speciality = Speciality.German
            },
            new Class
            {
                Id = 5,
                Name = "11v",
                SchoolId = 2,
                Speciality = Speciality.French
            });

        //Students
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = studentIvanId,
                VerificationKey = ivanVerificationCode,
                FirstName = "Ivan",
                MiddleName = "Ivanov",
                LastName = "Ivanov",
                IdNumber = "0141012442",
                ClassId = 1
            },
            new Student
            {
                Id = studentGenchoId,
                VerificationKey = genchoVerificationCode,
                FirstName = "Gencho",
                MiddleName = "Petkov",
                LastName = "Ginev",
                IdNumber = "0543121244",
                ClassId = 1
            },
            new Student()
            {
                Id = studentMartinId,
                VerificationKey = martinVerificationCode,
                FirstName = "Martin",
                MiddleName = "Ivanov",
                LastName = "Georgiev",
                IdNumber = "0741124324",
                ClassId = 2
            },
            new Student()
            {
                Id = studentGinkaId,
                VerificationKey = ginkaVerificationCode,
                FirstName = "Ginka",
                MiddleName = "Petrova",
                LastName = "Stoyanova",
                IdNumber = "0944174331",
                ClassId = 3
            },
            new Student
            {
                Id = studentJivkoId,
                VerificationKey = jivkoVerificationCode,
                FirstName = "Jivko",
                MiddleName = "Vasilev",
                LastName = "Donev",
                IdNumber = "1041124324",
                ClassId = 4
            },
            new Student
            {
                Id = studentPenchoId,
                VerificationKey = penchoVerificationCode,
                FirstName = "Pencho",
                MiddleName = "Angelov",
                LastName = "Mihov",
                IdNumber = "0945161226",
                ClassId = 5,
            },
            new Student
            {
                Id = studentDianaId,
                FirstName = "Diana",
                MiddleName = "Nedeva",
                LastName = "Kostova",
                IdNumber = "1148061932",
                ClassId = 4
            },
            new Student
            {
                Id = studentRuzhaId,
                FirstName = "Ruzha",
                MiddleName = "Todorova",
                LastName = "Veleva",
                IdNumber = "0852131993",
                ClassId = 5
            });

        //Teachers
        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                Id = teacherMariaId,
                VerificationKey = mariaVerificationCode,
                FirstName = "Maria",
                MiddleName = "Ivanova",
                LastName = "Petrova",
                IdNumber = "8008089119",
                Subject = Subject.Bulgarian,
            },
            new Teacher
            {
                Id = teacherStefkaId,
                VerificationKey = stefkaVerificationCode,
                FirstName = "Stefka",
                MiddleName = "Petkova",
                LastName = "Gineva",
                IdNumber = "9003021331",
                Subject = Subject.German
            },
            new Teacher
            {
                Id = teacherStamenId,
                VerificationKey = stamenVerificationCode,
                FirstName = "Stamen",
                MiddleName = "Georgiev",
                LastName = "Peev",
                IdNumber = "7211053143",
                Subject = Subject.IT
            },
            new Teacher
            {
                Id = teacherStoyankaId,
                VerificationKey = stoyankaVerificationCode,
                FirstName = "Stoyanka",
                MiddleName = "Doneva",
                LastName = "Peneva",
                IdNumber = "7105053113",
                Subject = Subject.French
            },
            new Teacher
            {
                Id = teacherPetarId,
                VerificationKey = petarVerificationCode,
                FirstName = "Petar",
                MiddleName = "Mladenov",
                LastName = "Chonev",
                IdNumber = "8210045421",
                Subject = Subject.Geography
            },
            new Teacher
            {
                Id = teacherBonchoId,
                VerificationKey = bonchoVerificationCode,
                FirstName = "Boncho",
                MiddleName = "Dimitrov",
                LastName = "Dimitrov",
                IdNumber = "8006210887",
                Subject = Subject.History
            });

        //Link between teachers and classes they teach
        modelBuilder.Entity<TeacherClass>().HasData(
            new TeacherClass
            {
                ClassId = 1,
                TeacherId = teacherMariaId,
            },
            new TeacherClass
            {
                ClassId = 2,
                TeacherId = teacherMariaId
            },
            new TeacherClass
            {
                ClassId = 1,
                TeacherId = teacherStefkaId,
            },
            new TeacherClass
            {
                ClassId = 2,
                TeacherId = teacherStefkaId
            },
            new TeacherClass
            {
                ClassId = 5,
                TeacherId = teacherStoyankaId
            },
            new TeacherClass
            {
                ClassId = 1,
                TeacherId = teacherStamenId
            },
            new TeacherClass
            {
                ClassId = 2,
                TeacherId = teacherStamenId
            },
            new TeacherClass
            {
                ClassId = 3,
                TeacherId = teacherStamenId
            },
            new TeacherClass
            {
                ClassId = 4,
                TeacherId = teacherPetarId
            },
            new TeacherClass
            {
                ClassId = 4,
                TeacherId = teacherBonchoId
            });
        
        //Projects
        modelBuilder.Entity<Project>().HasData(new Project
        {
            Id = 1,
            Name = "IT Kariera",
            Capacity = 40,
            StartDate = DateTime.Today.AddDays(-1),
            EndDate = DateTime.Today,
        });

        modelBuilder.Entity<SchoolProject>().HasData(new SchoolProject
        {
            SchoolId = 1,
            ProjectId = 1,
        });

        //Users
        var ivanId = Guid.NewGuid();
        var genchoId = Guid.NewGuid();
        var martinId = Guid.NewGuid();
        var ginkaId = Guid.NewGuid();
        var jivkoId = Guid.NewGuid();
        var penchoId = Guid.NewGuid();
        var mariaId = Guid.NewGuid();
        var stefkaId = Guid.NewGuid();
        var stamenId = Guid.NewGuid();
        var stoyankaId = Guid.NewGuid();
        var petarId = Guid.NewGuid();
        var bonchoId = Guid.NewGuid();
        
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = ivanId,
                AppId = studentIvanId,
                VerificationKey = ivanVerificationCode,
                FirstName = "Ivan",
                MiddleName = "Ivanov",
                LastName = "Ivanov",
                Email = "ivan@gmail.com",
                NormalizedEmail = "IVAN@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "ivan@gmail.com",
                NormalizedUserName = "IVAN@GMAIL.COM",
                IdNumber = "0141012442",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = genchoId,
                AppId = studentGenchoId,
                VerificationKey = genchoVerificationCode,
                FirstName = "Gencho",
                MiddleName = "Petkov",
                LastName = "Ginev",
                Email = "gencho@gmail.com",
                NormalizedEmail = "GENCHO@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "gencho@gmail.com",
                NormalizedUserName = "GENCHO@GMAIL.COM",
                IdNumber = "0543121244",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = martinId,
                AppId = studentMartinId,
                VerificationKey = martinVerificationCode,
                FirstName = "Martin",
                MiddleName = "Ivanov",
                LastName = "Georgiev",
                Email = "martin@gmail.com",
                NormalizedEmail = "MARTIN@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "martin@gmail.com",
                NormalizedUserName = "MARTIN@GMAIL.COM",
                IdNumber = "0741124324",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = ginkaId,
                AppId = studentGinkaId,
                VerificationKey = ginkaVerificationCode,
                FirstName = "Ginka",
                MiddleName = "Petrova",
                LastName = "Stoyanova",
                Email = "ginka@gmail.com",
                NormalizedEmail = "GINKA@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "ginka@gmail.com",
                NormalizedUserName = "GINKA@GMAIL.COM",
                IdNumber = "0944174331",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = jivkoId,
                AppId = studentJivkoId,
                VerificationKey = jivkoVerificationCode,
                FirstName = "Jivko",
                MiddleName = "Vasilev",
                LastName = "Donev",
                Email = "jivko@gmail.com",
                NormalizedEmail = "JIVKO@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "jivko@gmail.com",
                NormalizedUserName = "JIVKO@GMAIL.COM",
                IdNumber = "1041124324",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = penchoId,
                AppId = studentPenchoId,
                VerificationKey = penchoVerificationCode,
                FirstName = "Pencho",
                MiddleName = "Angelov",
                LastName = "Mihov",
                Email = "pencho@gmail.com",
                NormalizedEmail = "PENCHO@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "pencho@gmail.com",
                NormalizedUserName = "PENCHO@GMAIL.COM",
                IdNumber = "0945161226",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = mariaId,
                AppId = teacherMariaId,
                VerificationKey = mariaVerificationCode,
                FirstName = "Maria",
                MiddleName = "Ivanova",
                LastName = "Petrova",
                Email = "maria@gmail.com",
                NormalizedEmail = "MARIA@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "maria@gmail.com",
                NormalizedUserName = "MARIA@GMAIL.COM",
                IdNumber = "8008089119",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = stefkaId,
                AppId = teacherStefkaId,
                VerificationKey = stefkaVerificationCode,
                FirstName = "Stefka",
                MiddleName = "Petkova",
                LastName = "Gineva",
                Email = "stefka@gmail.com",
                NormalizedEmail = "STEFKA@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "stefka@gmail.com",
                NormalizedUserName = "STEFKA@GMAIL.COM",
                IdNumber = "9003021331",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = stamenId,
                AppId = teacherStamenId,
                VerificationKey = stamenVerificationCode,
                FirstName = "Stamen",
                MiddleName = "Georgiev",
                LastName = "Peev",
                Email = "stamen@gmail.com",
                NormalizedEmail = "STAMEN@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "stamen@gmail.com",
                NormalizedUserName = "STAMEN@GMAIL.COM",
                IdNumber = "7211053143",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = stoyankaId,
                AppId = teacherStoyankaId,
                VerificationKey = stoyankaVerificationCode,
                FirstName = "Stoyanka",
                MiddleName = "Doneva",
                LastName = "Peneva",
                Email = "stoyanka@gmail.com",
                NormalizedEmail = "STOYANKA@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "stoyanka@gmail.com",
                NormalizedUserName = "STOYANKA@GMAIL.COM",
                IdNumber = "7105053113",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = petarId,
                AppId = teacherPetarId,
                VerificationKey = petarVerificationCode,
                FirstName = "Petar",
                MiddleName = "Mladenov",
                LastName = "Chonev",
                Email = "petar@gmail.com",
                NormalizedEmail = "PETAR@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "petar@gmail.com",
                NormalizedUserName = "PETAR@GMAIL.COM",
                IdNumber = "8210045421",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false
            },
            new ApplicationUser
            {
                Id = bonchoId,
                AppId = teacherBonchoId,
                VerificationKey = bonchoVerificationCode,
                FirstName = "Boncho",
                MiddleName = "Dimitrov",
                LastName = "Dimitrov",
                Email = "boncho@gmail.com",
                NormalizedEmail = "BONCHO@GMAIL.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Parola123"),
                UserName = "boncho@gmail.com",
                NormalizedUserName = "BONCHO@GMAIL.COM",
                IdNumber = "8006210887",
                BirthDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                IsAuthenticated = true,
                IsGuest = false,
            });
        
        //Roles
        var studentRoleId = Guid.NewGuid();
        var teacherRoleId = Guid.NewGuid();
        
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(
            new IdentityRole<Guid>
            {
                Id = studentRoleId,
                Name = "Student",
                NormalizedName = "STUDENT"
            });
        
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(
            new IdentityRole<Guid>
            {
                Id = teacherRoleId,
                Name = "Teacher",
                NormalizedName = "TEACHER"
            });
        
        //Assign Roles
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = ivanId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = genchoId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = martinId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = ginkaId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = jivkoId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = penchoId,
                RoleId = studentRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = mariaId,
                RoleId = teacherRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = stefkaId,
                RoleId = teacherRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = stamenId,
                RoleId = teacherRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = stoyankaId,
                RoleId = teacherRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = petarId,
                RoleId = teacherRoleId
            },
            new IdentityUserRole<Guid>
            {
                UserId = bonchoId,
                RoleId = teacherRoleId
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