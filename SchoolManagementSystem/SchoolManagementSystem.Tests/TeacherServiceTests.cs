using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Tests;

[TestFixture]
public class TeacherServiceTests
{
    private ApplicationDbContext _context;
    private Mock<UserManager<ApplicationUser>> _userManagerMock;
    private TeacherService _teacherService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "SchoolManagementSystemTestDb")
            .Options;

        _context = new ApplicationDbContext(options);
        _userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null,
            null, null, null, null, null, null, null);
        _teacherService = new TeacherService(_context, _userManagerMock.Object);
    }

    [TearDown]
    public void TearDown()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

    [Test]
    public async Task GetDashboardAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.GetDashboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetDashboardAsync_TeacherNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.GetDashboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetGradesDashboardAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.GetGradesDashboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetGradesDashboardAsync_TeacherNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.GetGradesDashboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetGradesDashboardAsync_TeacherFound_ReturnsViewModel()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        var teacher = new Teacher
        {
            IdNumber = "123",
            FirstName = "jkdwjkdwjkdwj",
            LastName = "jkdwjkdwj",
            MiddleName = "jkdwjkdwj",
            TeachersClasses = new List<TeacherClass>
                { new TeacherClass { Class = new Class { Name = "Class 1" } } }
        };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _context.Teachers.Add(teacher);
        await _context.SaveChangesAsync();

        var result = await _teacherService.GetGradesDashboardAsync("someUserId");

        Assert.NotNull(result);
        Assert.AreEqual("Class 1", result!.Classes.First().ClassName);
    }

    [Test]
    public async Task GetClassGradesAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.GetClassGradesAsync(1, "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetClassGradesAsync_TeacherNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.GetClassGradesAsync(1, "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetClassGradesAsync_ReturnsGrades()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        var teacher = new Teacher {FirstName = "Blabla", MiddleName = "BlaBlaBLa", LastName = "Dooooe",IdNumber = "123", Subject = Subject.Maths };
        var student = new Student
        {
            FirstName = "John",
            MiddleName = "A",
            LastName = "Doe",
            ClassId = 1,
            IdNumber = "3040506070",
            Grades = new List<Grade> { new Grade { Subject = Subject.Maths, GradeValue = 5 } }
        };

        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _context.Teachers.Add(teacher);
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        var result = await _teacherService.GetClassGradesAsync(1, "someUserId");

        Assert.NotNull(result);
        Assert.AreEqual(1, result!.Count);
        Assert.AreEqual("John A Doe", result.First().StudentName);
    }

    [Test]
    public async Task AddGradeAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.AddGradeAsync(5, Guid.NewGuid(), "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task AddGradeAsync_TeacherOrStudentNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.AddGradeAsync(5, Guid.NewGuid(), "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task AddGradeAsync_AddsGrade_ReturnsClassId()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        var teacher = new Teacher
        {
            FirstName = "John",
            MiddleName = "A",
            LastName = "Dooooe",
            IdNumber = "123", TeachersClasses = new List<TeacherClass> { new TeacherClass { ClassId = 1 } },
            Subject = Subject.Maths
        };
        var student = new Student { Id = Guid.NewGuid(), ClassId = 1, Grades = new List<Grade>() , FirstName = "Bom", MiddleName = "Bom", LastName = "Clat", IdNumber = "1002003000" };

        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _context.Teachers.Add(teacher);
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        var result = await _teacherService.AddGradeAsync(5, student.Id, "someUserId");

        Assert.NotNull(result);
        Assert.AreEqual(1, result);
    }

    [Test]
    public async Task DeleteGradeAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.DeleteGradeAsync(1, Guid.NewGuid(), "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task DeleteGradeAsync_TeacherOrStudentNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { AppId = Guid.NewGuid() };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.DeleteGradeAsync(1, Guid.NewGuid(), "someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetScoreboardAsync_UserNotFound_ReturnsNull()
    {
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((ApplicationUser?)null);

        var result = await _teacherService.GetScoreboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetScoreboardAsync_TeacherNotFound_ReturnsNull()
    {
        var user = new ApplicationUser { IdNumber = "123" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var result = await _teacherService.GetScoreboardAsync("someUserId");

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetScoreboardAsync_TeacherFound_ReturnsViewModel()
    {
        var teacherId = Guid.NewGuid();
        var user = new ApplicationUser { IdNumber = "123" };
        var teacher = new Teacher
        {
            Id = teacherId,
            FirstName = "John",
            LastName = "Doe",
            MiddleName = "Doe",
            IdNumber = "123",
            TeachersClasses = new List<TeacherClass>
            {
                new TeacherClass
                {
                    Class = new Class
                    {
                        Name = "Class 1",
                        Students = new List<Student>
                        {
                            new Student
                            {
                                FirstName = "John",
                                MiddleName = "A",
                                LastName = "Doe",
                                ClassId = 1,
                                IdNumber = "1010202030",
                                Grades = new List<Grade>
                                {
                                    new Grade { Subject = Subject.Maths, GradeValue = 5, TeacherId = teacherId }
                                }
                            }
                        }
                    }
                }
            }
        };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _context.Teachers.Add(teacher);
        await _context.SaveChangesAsync();

        var result = await _teacherService.GetScoreboardAsync("someUserId");

        Assert.NotNull(result);
        Assert.AreEqual(1, result!.StudentScores.Count);
        Assert.AreEqual("John A Doe", result.StudentScores.First().FullName);
    }
}