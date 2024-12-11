using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Web.Areas.Admin.Controllers;
using SchoolManagementSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Common.Enums;
using X.PagedList;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class AdminSchoolsControllerTests
    {
        private ApplicationDbContext _context;
        private AdminSchoolsController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SchoolManagementSystemTestDb")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new AdminSchoolsController(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
            _controller.Dispose();
        }

        [Test]
        public async Task SchoolsList_ReturnsViewResult_WithListOfSchools()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var result = _controller.SchoolsList(null) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as IPagedList<SchoolsAdminViewModel>;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Count);
            Assert.AreEqual("Test School", model.First().SchoolName);
        }

        [Test]
        public async Task DeleteSchool_RemovesSchoolAndClasses_RedirectsToSchoolsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            var classEntity = new Class { Name = "Class 1", School = school };

            _context.Schools.Add(school);
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            var result = await _controller.DeleteSchool(school.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("SchoolsList", result.ActionName);
            Assert.AreEqual(0, _context.Schools.Count());
            Assert.AreEqual(0, _context.Classes.Count());
        }

        [Test]
        public async Task AddClass_Get_ReturnsViewResult_WithViewModel()
        {
            var school = new School { Name = "Test School", Address = "Test Address 4" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var result = await _controller.AddClass(school.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ClassAddViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(school.Id, model.SchoolId);
        }

        [Test]
        public async Task AddClass_Post_AddsClass_RedirectsToSchoolsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address 3" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var model = new ClassAddViewModel
            {
                Name = "New Class",
                Speciality = Speciality.Mathematics.ToString(),
                SchoolId = school.Id
            };

            var result = await _controller.AddClass(model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("SchoolsList", result.ActionName);
            Assert.AreEqual(1, _context.Classes.Count());
            Assert.AreEqual("New Class", _context.Classes.First().Name);
        }

        [Test]
        public async Task ManageSchool_ReturnsViewResult_WithSchoolDetails()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var result = await _controller.ManageSchool(school.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as SchoolManageViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("Test School", model.Name);
            Assert.AreEqual("Test Address", model.Address);
        }

        [Test]
        public async Task ManageSchool_Post_UpdatesSchool_RedirectsToSchoolsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var model = new SchoolManageViewModel
            {
                Id = school.Id,
                Name = "Updated School",
                Address = "Updated Address",
                Description = "Updated Description",
                LogoUrl = "UpdatedLogoUrl"
            };

            var result = await _controller.ManageSchool(model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("SchoolsList", result.ActionName);
            var updatedSchool = _context.Schools.First();
            Assert.AreEqual("Updated School", updatedSchool.Name);
            Assert.AreEqual("Updated Address", updatedSchool.Address);
            Assert.AreEqual("Updated Description", updatedSchool.Description);
            Assert.AreEqual("UpdatedLogoUrl", updatedSchool.LogoUrl);
        }

        [Test]
        public async Task DeleteClass_RemovesClass_ReturnsManageSchoolView()
        {
            var school = new School { Name = "Test School", Address = "Test Address 2" };
            var classEntity = new Class { Name = "Class 1", School = school };

            _context.Schools.Add(school);
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            var model = new SchoolManageViewModel { Id = school.Id };
            var result = await _controller.DeleteClass(classEntity.Id, model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("ManageSchool", result.ViewName);
            Assert.AreEqual(0, _context.Classes.Count());
        }

        [Test]
        public async Task CreateSchool_Get_ReturnsViewResult()
        {
            var result = _controller.CreateSchool() as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as SchoolCreateViewModel;
            Assert.IsNotNull(model);
        }

        [Test]
        public async Task CreateSchool_Post_AddsSchool_RedirectsToSchoolsList()
        {
            var model = new SchoolCreateViewModel
            {
                Name = "New School",
                Address = "New Address",
                Description = "New Description",
                LogoUrl = "NewLogoUrl"
            };

            var result = await _controller.CreateSchool(model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("SchoolsList", result.ActionName);
            Assert.AreEqual(1, _context.Schools.Count());
            Assert.AreEqual("New School", _context.Schools.First().Name);
        }
    }
}
