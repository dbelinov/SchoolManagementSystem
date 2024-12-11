using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.Areas.Admin.Controllers;
using SchoolManagementSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using X.PagedList;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class AdminStudentsControllerTests
    {
        private ApplicationDbContext _context;
        private Mock<UserManager<ApplicationUser>> _userManagerMock;
        private Mock<IUserService> _userServiceMock;
        private AdminStudentsController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SchoolManagementSystemTestDb")
                .Options;

            _context = new ApplicationDbContext(options);
            _userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);
            _userServiceMock = new Mock<IUserService>();
            _controller = new AdminStudentsController(_context, _userManagerMock.Object, _userServiceMock.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
            _controller.Dispose();
        }

        [Test]
        public async Task StudentsList_ReturnsViewResult_WithListOfStudents()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            var classEntity = new Class { Name = "Class 1", School = school };
            var student = new Student { FirstName = "John", MiddleName = "A", LastName = "Doe", Class = classEntity, IdNumber = "123" };

            _context.Schools.Add(school);
            _context.Classes.Add(classEntity);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            var result = _controller.StudentsList(null) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as IPagedList<StudentAdminViewModel>;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Count);
            Assert.AreEqual("John A Doe", model.First().FullName);
        }

        [Test]
        public async Task DeleteStudent_RemovesStudentAndUser_RedirectsToStudentsList()
        {
            var student = new Student { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "1239876542" };
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", AppId = student.Id , IdNumber = student.IdNumber };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
            _userManagerMock.Setup(um => um.DeleteAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var result = await _controller.DeleteStudent(student.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("StudentsList", result.ActionName);
            Assert.AreEqual(0, _context.Students.Count());
        }

        [Test]
        public async Task GenerateValidationKey_UpdatesStudentAndUser_RedirectsToStudentsList()
        {
            var student = new Student { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "1234567890" };
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", AppId = student.Id, IdNumber = "1234567890" };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            _userManagerMock.Setup(um => um.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var result = await _controller.GenerateValidationKey(student.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("StudentsList", result.ActionName);
            Assert.AreNotEqual(Guid.Empty, student.VerificationKey);
        }

        [Test]
        public async Task ManageStudent_ReturnsViewResult_WithStudentDetails()
        {
            var student = new Student { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123" };
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            var result = await _controller.ManageStudent(student.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as StudentManageViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("John", model.FirstName);
            Assert.AreEqual("A", model.MiddleName);
            Assert.AreEqual("Doe", model.LastName);
            Assert.AreEqual("123", model.IdNumber);
        }

        [Test]
        public async Task ManageStudent_Post_UpdatesStudentAndUser_RedirectsToStudentsList()
        {
            var student = new Student { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123" };
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123", AppId = student.Id };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            _userManagerMock.Setup(um => um.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var model = new StudentManageViewModel
            {
                FirstName = "Jane",
                MiddleName = "B",
                LastName = "Smith",
                IdNumber = "456"
            };

            var result = await _controller.ManageStudent(student.Id, model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("StudentsList", result.ActionName);

            var updatedStudent = _context.Students.First();
            Assert.AreEqual("Jane", updatedStudent.FirstName);
            Assert.AreEqual("B", updatedStudent.MiddleName);
            Assert.AreEqual("Smith", updatedStudent.LastName);
            Assert.AreEqual("456", updatedStudent.IdNumber);
        }

        [Test]
        public async Task CreateStudent_Get_ReturnsViewResult_WithSchools()
        {
            var school = new School { Name = "Test School" , Address = "Test Address 4" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var result = await _controller.CreateStudent() as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as StudentCreateViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Schools.Count);
            Assert.AreEqual("Test School", model.Schools.First().Name);
        }

        [Test]
        public async Task CreateStudent_InvalidModelState_ReturnsViewResult_WithModel()
        {
            _controller.ModelState.AddModelError("Error", "Sample error");

            var model = new StudentCreateViewModel { FirstName = "John", LastName = "Doe" };

            var result = await _controller.CreateStudent(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(model, result.Model);
        }
        
        [Test]
        public async Task CreateStudent_ExistingUser_AssignsUserRole()
        {
            var school = new School { Name = "Test School", Address = "Test Address 12" };
            var classEntity = new Class { Name = "Class 1", School = school };
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123" };

            _context.Schools.Add(school);
            _context.Classes.Add(classEntity);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            var model = new StudentCreateViewModel
            {
                FirstName = "John",
                MiddleName = "A",
                LastName = "Doe",
                IdNumber = "123",
                ClassId = classEntity.Id
            };

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            _userServiceMock.Setup(us => us.AssignToStudentOrTeacherAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(true);

            var result = await _controller.CreateStudent(model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("StudentsList", result.ActionName);
            Assert.AreEqual(1, _context.Students.Count());
            Assert.AreEqual("John", _context.Students.First().FirstName);

            _userServiceMock.Verify(us => us.AssignToStudentOrTeacherAsync(user), Times.Once);
        }
    }
}