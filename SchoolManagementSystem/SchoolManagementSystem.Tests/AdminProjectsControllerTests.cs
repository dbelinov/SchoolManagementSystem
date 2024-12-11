using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Web.Areas.Admin.Controllers;
using SchoolManagementSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class AdminProjectsControllerTests
    {
        private ApplicationDbContext _context;
        private AdminProjectsController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SchoolManagementSystemTestDb")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new AdminProjectsController(_context);
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
        public async Task ProjectsList_ReturnsViewResult_WithListOfProjects()
        {
            var school = new School { Name = "Test School", Address = "Test Address" };
            var project = new Project { Name = "Test Project" };
            var schoolProject = new SchoolProject { School = school, Project = project };

            _context.Schools.Add(school);
            _context.Projects.Add(project);
            _context.SchoolsProjects.Add(schoolProject);
            await _context.SaveChangesAsync();

            var result = _controller.ProjectsList(school.Id, null) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as IPagedList<ProjectAdminViewModel>;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Count);
            Assert.AreEqual("Test Project", model.First().Name);
        }

        [Test]
        public async Task CreateProject_ReturnsViewResult_WithAvailableProjects()
        {
            var school = new School { Name = "Test School", Address = "Test Address 4" };
            var project = new Project { Name = "Available Project" };

            _context.Schools.Add(school);
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            var result = await _controller.CreateProject(school.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ProjectCreateViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.AvailableProjects.Count);
            Assert.AreEqual("Available Project", model.AvailableProjects.First().Name);
        }

        [Test]
        public async Task CreateProject_Post_AddsProject_RedirectsToProjectsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address 5" };
            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            var model = new ProjectCreateViewModel
            {
                Name = "New Project",
                Capacity = 30,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1)
            };

            var result = await _controller.CreateProject(school.Id, model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("ProjectsList", result.ActionName);
            Assert.AreEqual(school.Id, result.RouteValues["schoolId"]);
            Assert.AreEqual(1, _context.Projects.Count());
        }

        [Test]
        public async Task AddProject_AddsSchoolProject_RedirectsToProjectsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address 6" };
            var project = new Project { Name = "Test Project" };

            _context.Schools.Add(school);
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            var result = await _controller.AddProject(school.Id, project.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("ProjectsList", result.ActionName);
            Assert.AreEqual(school.Id, result.RouteValues["schoolId"]);
            Assert.AreEqual(1, _context.SchoolsProjects.Count());
        }

        [Test]
        public async Task ManageProject_ReturnsViewResult_WithProjectDetails()
        {
            var project = new Project { Name = "Test Project", Capacity = 30 };
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            var result = await _controller.ManageProject(1, project.Id) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ProjectManageViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual("Test Project", model.Name);
        }

        [Test]
        public async Task ManageProject_Post_UpdatesProject_RedirectsToProjectsList()
        {
            var school = new School { Name = "Test School" , Address = "Test Address 2" };
            var project = new Project { Name = "Test Project", Capacity = 30 };
            _context.Schools.Add(school);
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            var model = new ProjectManageViewModel
            {
                Name = "Updated Project",
                Capacity = 50,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1)
            };

            var result = await _controller.ManageProject(project.Id, model) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("SchoolsList", result.ActionName);
            var updatedProject = _context.Projects.First();
            Assert.AreEqual("Updated Project", updatedProject.Name);
            Assert.AreEqual(50, updatedProject.Capacity);
        }

        [Test]
        public async Task DeleteProject_DeletesProject_RedirectsToProjectsList()
        {
            var school = new School { Name = "Test School", Address = "Test Address 3" };
            var project = new Project { Name = "Test Project" };
            _context.Schools.Add(school);
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            var result = await _controller.DeleteProject(school.Id, project.Id) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("ProjectsList", result.ActionName);
            Assert.AreEqual(school.Id, result.RouteValues["schoolId"]);
            Assert.AreEqual(0, _context.Projects.Count());
        }
    }
}
