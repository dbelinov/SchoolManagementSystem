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
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Web.ViewModels.Teacher;
using X.PagedList;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class AdminTeachersControllerTests
    {
        private ApplicationDbContext _context;
        private Mock<UserManager<ApplicationUser>> _userManagerMock;
        private Mock<IUserService> _userServiceMock;
        private AdminTeachersController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SchoolManagementSystemTestDb")
                .Options;

            _context = new ApplicationDbContext(options);
            _userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);
            _userServiceMock = new Mock<IUserService>();
            _controller = new AdminTeachersController(_context, _userManagerMock.Object, _userServiceMock.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
            _controller.Dispose();
        }

        [Test]
        public async Task TeachersList_ReturnsViewResult_WithListOfTeachers()
        {
            var teacher = new Teacher { FirstName = "John", MiddleName = "A", LastName = "Doe", Subject = Subject.Maths, IdNumber = "123"};

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            var result = _controller.TeachersList(null) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as IPagedList<TeacherAdminViewModel>;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Count);
            Assert.AreEqual("John A Doe", model.First().FullName);
        }

        [Test]
        public async Task DeleteTeacher_RemovesTeacherAndUser_RedirectsToTeachersList()
        {
            var teacher = new Teacher { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "12345"};
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", AppId = teacher.Id, IdNumber = teacher.IdNumber };

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
            _userManagerMock.Setup(um => um.DeleteAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var result = await _controller.DeleteTeacher(teacher.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("TeachersList", result.ActionName);
            Assert.AreEqual(0, _context.Teachers.Count());
        }

        [Test]
        public async Task GenerateValidationKey_UpdatesTeacherAndUser_RedirectsToTeachersList()
        {
            var teacher = new Teacher { FirstName = "John", MiddleName = "A", LastName = "Doe" , IdNumber = "1234" };
            var user = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", AppId = teacher.Id, IdNumber = teacher.IdNumber };

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            _userManagerMock.Setup(um => um.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var result = await _controller.GenerateValidationKey(teacher.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("TeachersList", result.ActionName);
            Assert.AreNotEqual(Guid.Empty, teacher.VerificationKey);
        }

        [Test]
        public async Task ManageTeacher_ReturnsViewResult_WithTeacherDetails()
        {
            var teacher = new Teacher { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123", Subject = Subject.Maths };
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            var result = await _controller.ManageTeacher(teacher.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as TeacherManageViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("John", model.FirstName);
            Assert.AreEqual("A", model.MiddleName);
            Assert.AreEqual("Doe", model.LastName);
            Assert.AreEqual("123", model.IdNumber);
            Assert.AreEqual("Maths", model.Subject);
        }

        [Test]
        public async Task ManageTeacher_Post_UpdatesTeacher_RedirectsToTeachersList()
        {
            var teacher = new Teacher { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123", Subject = Subject.Maths };

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            var model = new TeacherManageViewModel
            {
                FirstName = "Jane",
                MiddleName = "B",
                LastName = "Smith",
                IdNumber = "456",
                Subject = "Chemistry"
            };

            var result = await _controller.ManageTeacher(teacher.Id, model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("TeachersList", result.ActionName);

            var updatedTeacher = _context.Teachers.First();
            Assert.AreEqual("Jane", updatedTeacher.FirstName);
            Assert.AreEqual("B", updatedTeacher.MiddleName);
            Assert.AreEqual("Smith", updatedTeacher.LastName);
            Assert.AreEqual("456", updatedTeacher.IdNumber);
            Assert.AreEqual(Subject.Chemistry, updatedTeacher.Subject);
        }

        [Test]
        public async Task CreateTeacher_Get_ReturnsViewResult_WithSchools()
        {
            var school = new School { Name = "Test School", Address = "Test Address 2"};
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var result = await _controller.CreateTeacher() as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as TeacherCreateViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Schools.Count);
            Assert.AreEqual("Test School", model.Schools.First().Name);
        }

        [Test]
        public async Task CreateTeacher_InvalidModelState_ReturnsViewResult_WithModel()
        {
            _controller.ModelState.AddModelError("Error", "Sample error");

            var model = new TeacherCreateViewModel { FirstName = "John", LastName = "Doe" };

            var result = await _controller.CreateTeacher(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(model, result.Model);
        }

        [Test]
        public async Task CreateTeacher_SchoolNotFound_ReturnsBadRequest()
        {
            var model = new TeacherCreateViewModel
            {
                FirstName = "John",
                MiddleName = "A",
                LastName = "Doe",
                Subject = "Maths",
                IdNumber = "123",
                SchoolId = -1,
                Classes = "Class 1"
            };
            var result = await _controller.CreateTeacher(model) as BadRequestResult;

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task CreateTeacher_ClassNotFound_ReturnsViewResult_WithModelError()
        {
            var school = new School { Name = "Test School", Address = "Test Address 6" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var model = new TeacherCreateViewModel
            {
                FirstName = "John",
                MiddleName = "A",
                LastName = "Doe",
                Subject = "Maths",
                IdNumber = "123",
                SchoolId = school.Id,
                Classes = "Nonexistent Class"
            };

            var result = await _controller.CreateTeacher(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(model, result.Model);
            Assert.IsTrue(_controller.ModelState.ContainsKey(string.Empty));
        }
        
        [Test]
        public async Task CreateTeacher_AddsTeacherClassesAndAssignsExistingUser()
        {
            var school = new School { Name = "Test School", Address = "Test Address 8" };
            var classEntity = new Class { Name = "Class 1", School = school };
            var existingUser = new ApplicationUser { FirstName = "John", MiddleName = "A", LastName = "Doe", IdNumber = "123" };

            _context.Schools.Add(school);
            _context.Classes.Add(classEntity);
            await _context.Users.AddAsync(existingUser);
            await _context.SaveChangesAsync();

            var model = new TeacherCreateViewModel
            {
                FirstName = "John",
                MiddleName = "A",
                LastName = "Doe",
                Subject = "Maths",
                IdNumber = "123",
                SchoolId = school.Id,
                Classes = "Class 1"
            };

            _userManagerMock.Setup(um => um.Users).Returns(_context.Users.AsQueryable());
            _userServiceMock.Setup(us => us.AssignToStudentOrTeacherAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(true);

            var result = await _controller.CreateTeacher(model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("TeachersList", result.ActionName);

            var teacher = _context.Teachers.First();
            Assert.AreEqual("John", teacher.FirstName);
            Assert.AreEqual(1, _context.TeachersClasses.Count());
            Assert.AreEqual(teacher.Id, _context.TeachersClasses.First().TeacherId);
            Assert.AreEqual(classEntity.Id, _context.TeachersClasses.First().ClassId);

            _userServiceMock.Verify(us => us.AssignToStudentOrTeacherAsync(existingUser), Times.Once);
        }


    }
}