using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SchoolManagementSystem.Web.Areas.Admin.Controllers;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class AdminControllerTests
    {
        private AdminController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new AdminController();
        }

        [TearDown]
        public void TearDown()
        {
            _controller.Dispose();
        }

        [Test]
        public void Index_ReturnsViewResult_WithDashboardView()
        {
            var result = _controller.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Dashboard", result.ViewName);
        }
    }
}