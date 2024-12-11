using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Tests.Services
{
    [TestFixture]
    public class StudentServiceTests
    {
        private ApplicationDbContext _context;
        private Mock<UserManager<ApplicationUser>> _mockUserManager;
        private StudentService _studentService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _mockUserManager = MockUserManager<ApplicationUser>();
            _studentService = new StudentService(_context, _mockUserManager.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            return new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
        }

        [Test]
        public async Task GetLoggedInUserAsync_UserFound_ReturnsUser()
        {
            // Arrange
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "testuser")
            }, "mock"));

            var user = new ApplicationUser { UserName = "testuser" };
            _mockUserManager.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            // Act
            var result = await _studentService.GetLoggedInUserAsync(claimsPrincipal);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testuser", result.UserName);
        }

        [Test]
        public async Task GetStudentByUserIdAsync_StudentFound_ReturnsStudent()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var project = new Project { Id = 1, Name = "Project1", Capacity = 10 };
            var school = new School { Id = 1, Name = "School1" , Address = "Address1" };
            var class1 = new Class { Id = 1, Name = "Class1", SchoolId = school.Id, School = school };
            var student = new Student
            {
                Id = userId,
                FirstName = "testfirst",
                LastName = "testlast",
                MiddleName = "testmiddlename",
                ClassId = class1.Id,
                Class = class1,
                IdNumber = "1122334455"
            };

            await _context.Projects.AddAsync(project);
            await _context.Schools.AddAsync(school);
            await _context.Classes.AddAsync(class1);
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            // Act
            var result = await _studentService.GetStudentByUserIdAsync(userId);

            // Assert
            Assert.IsNotNull(result, "Student was not found.");
            Assert.AreEqual(userId, result.Id, "Student ID does not match.");
        }

        [Test]
        public void GetDashboardViewModel_StudentWithGrades_ReturnsCorrectViewModel()
        {
            // Arrange
            var student = new Student
            {
                Grades = new[]
                {
                    new Grade { GradeValue = 4 },
                    new Grade { GradeValue = 5 }
                }.ToList(),
                StudentsProjects = new []
                {
                    new StudentProject(),
                    new StudentProject()
                }.ToList()
            };

            // Act
            var result = _studentService.GetDashboardViewModel(student);

            // Assert
            Assert.AreEqual("4.50", result.AverageGrade);
            Assert.AreEqual(2, result.GradesCount);
            Assert.AreEqual(2, result.ProjectsCount);
        }

        [Test]
        public void GetGradesViewModel_StudentWithGrades_ReturnsCorrectViewModel()
        {
            // Arrange
            var student = new Student
            {
                Grades = new[]
                {
                    new Grade { Subject = Subject.Maths, GradeValue = 4 },
                    new Grade { Subject = Subject.Maths, GradeValue = 5 },
                    new Grade { Subject = Subject.Chemistry, GradeValue = 3 }
                }.ToList()
            };

            // Act
            var result = _studentService.GetGradesViewModel(student);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(Subject.Maths, result[0].Subject);
            Assert.AreEqual(2, result[0].Grades.Count);
            Assert.AreEqual(Subject.Chemistry, result[1].Subject);
            Assert.AreEqual(1, result[1].Grades.Count);
        }

        [Test]
        public async Task GetStudentProjectsAsync_UserWithProjects_ReturnsCorrectViewModel()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "testuser")
            }, "mock"));

            var user = new ApplicationUser { Id = userId, UserName = "testuser", AppId = userId, FirstName = "testfirst2", LastName = "testlast2" , MiddleName = "testmiddlename2", IdNumber = "1122334456" };
            var project3 = new Project { Id = 3, Name = "Project3", Capacity = 10 };
            var project4 = new Project { Id = 4, Name = "Project4", Capacity = 10 };
            var school = new School { Id = 2, Name = "School2", Address = "Address1" };
            var class2 = new Class { Id = 2, Name = "Class2", SchoolId = school.Id, School = school };
            var student = new Student
            {
                Id = userId,
                FirstName = "testfirst2",
                LastName = "testlast2",
                MiddleName = "testmiddlename2",
                ClassId = class2.Id,
                Class = class2,
                IdNumber = "1122334456"
            };

            await _context.Users.AddAsync(user);
            await _context.Projects.AddRangeAsync(project3, project4);
            await _context.Schools.AddAsync(school);
            await _context.Classes.AddAsync(class2);
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            _mockUserManager.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            var schoolProject1 = new SchoolProject { SchoolId = school.Id, ProjectId = project3.Id };
            var schoolProject2 = new SchoolProject { SchoolId = school.Id, ProjectId = project4.Id };
            var studentProject = new StudentProject { StudentId = student.Id, ProjectId = project3.Id };

            await _context.SchoolsProjects.AddRangeAsync(schoolProject1, schoolProject2);
            await _context.StudentsProjects.AddAsync(studentProject);
            await _context.SaveChangesAsync();

            // Act
            var result = await _studentService.GetStudentProjectsAsync(claimsPrincipal);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.AllProjects.Count);
            Assert.AreEqual(1, result.UserProjects.Count);
        }

        [Test]
        public async Task JoinProjectAsync_StudentJoinsProject_ReturnsTrue()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "testuser")
            }, "mock"));

            var user = new ApplicationUser { Id = userId, UserName = "testuser", AppId = userId, FirstName = "testfirst7", LastName = "testlast7" , MiddleName = "testmiddlename7", IdNumber = "1122334477" };
            var project = new Project { Id = 5, Name = "Project1", Capacity = 10 };
            var school = new School { Id = 3, Name = "School1", Address = "Address1" };
            var class1 = new Class { Id = 3, Name = "Class1", SchoolId = school.Id, School = school };
            var student = new Student
            {
                Id = userId,
                FirstName = "testfirst7",
                LastName = "testlast7",
                MiddleName = "testmiddlename7",
                ClassId = class1.Id,
                Class = class1,
                IdNumber = "1122334477"
            };

            await _context.Users.AddAsync(user);
            await _context.Projects.AddAsync(project);
            await _context.Classes.AddAsync(class1);
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            _mockUserManager.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            // Act
            var result = await _studentService.JoinProjectAsync(claimsPrincipal, project.Id);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, student.StudentsProjects.Count);
        }

        [Test]
        public async Task LeaveProjectAsync_StudentLeavesProject_ReturnsTrue()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "testuser100")
            }, "mock"));

            var user = new ApplicationUser { Id = userId, UserName = "testuser100", AppId = userId, FirstName = "testfirst100", LastName = "testlast100" , MiddleName = "testmiddlename100", IdNumber = "1122334010" };
            var project = new Project { Id = 6, Name = "Project1", Capacity = 10 };
            var school = new School { Id = 6, Name = "School1", Address = "Address1" };
            var class1 = new Class { Id = 6, Name = "Class1", SchoolId = school.Id, School = school };
            var student = new Student
            {
                Id = userId,
                FirstName = "testfirst100",
                LastName = "testlast100",
                MiddleName = "testmiddlename100",
                ClassId = class1.Id,
                Class = class1,
                IdNumber = "1122334010"
            };

            await _context.Users.AddAsync(user);
            await _context.Projects.AddAsync(project);
            await _context.Classes.AddAsync(class1);
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            var studentProject = new StudentProject { StudentId = student.Id, ProjectId = project.Id };
            await _context.StudentsProjects.AddAsync(studentProject);
            await _context.SaveChangesAsync();

            _mockUserManager.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            // Act
            var result = await _studentService.LeaveProjectAsync(claimsPrincipal, project.Id);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, student.StudentsProjects.Count);
        }
    }
}
