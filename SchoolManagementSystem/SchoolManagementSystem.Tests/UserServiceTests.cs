using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;

namespace SchoolManagementSystem.Tests.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole<Guid>> _roleManager;
        private UserService _userService;
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase(databaseName: "TestDatabase"));

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            _serviceProvider = services.BuildServiceProvider();
            _context = _serviceProvider.GetRequiredService<ApplicationDbContext>();

            var userStore = _serviceProvider.GetRequiredService<IUserStore<ApplicationUser>>();
            var roleStore = _serviceProvider.GetRequiredService<IRoleStore<IdentityRole<Guid>>>();

            _userManager = new UserManager<ApplicationUser>(
                userStore, 
                Mock.Of<IOptions<IdentityOptions>>(), 
                new PasswordHasher<ApplicationUser>(), 
                Array.Empty<IUserValidator<ApplicationUser>>(), 
                Array.Empty<IPasswordValidator<ApplicationUser>>(), 
                new UpperInvariantLookupNormalizer(), 
                new IdentityErrorDescriber(), 
                null, 
                new NullLogger<UserManager<ApplicationUser>>());

            _roleManager = new RoleManager<IdentityRole<Guid>>(
                roleStore, 
                Array.Empty<IRoleValidator<IdentityRole<Guid>>>(), 
                new UpperInvariantLookupNormalizer(), 
                new IdentityErrorDescriber(), 
                new NullLogger<RoleManager<IdentityRole<Guid>>>());

            _userService = new UserService(_userManager, _roleManager, _context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
            _serviceProvider.Dispose();
            _roleManager.Dispose();
            _userManager.Dispose();
        }

        [Test]
        public async Task AssignToStudentOrTeacherAsync_UserMatchesStudent_ReturnsTrue()
        {
            // Arrange
            var user = new ApplicationUser
            {
                IdNumber = "1122334455",
                FirstName = "testfirst",
                MiddleName = "testmiddle",
                LastName = "testlast",
                SecurityStamp = Guid.NewGuid().ToString()  // Setting SecurityStamp
            };

            var student = new Student
            {
                Id = Guid.NewGuid(),
                IdNumber = "1122334455",
                FirstName = "testfirst",
                MiddleName = "testmiddle",
                LastName = "testlast",
                VerificationKey = Guid.NewGuid()
            };

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            await _userManager.CreateAsync(user);  // Save user to the database

            // Act
            var result = await _userService.AssignToStudentOrTeacherAsync(user);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(student.Id, user.AppId);
            Assert.AreEqual(student.VerificationKey, user.VerificationKey);
            Assert.IsFalse(user.IsGuest);
        }

        [Test]
        public async Task AssignToStudentOrTeacherAsync_UserMatchesTeacher_ReturnsTrue()
        {
            // Arrange
            var user = new ApplicationUser
            {
                IdNumber = "1122334460",
                FirstName = "testfirst1",
                MiddleName = "testmiddle1",
                LastName = "testlast1",
                SecurityStamp = Guid.NewGuid().ToString()  // Setting SecurityStamp
            };

            var teacher = new Teacher
            {
                Id = Guid.NewGuid(),
                IdNumber = "1122334460",
                FirstName = "testfirst1",
                MiddleName = "testmiddle1",
                LastName = "testlast1",
                VerificationKey = Guid.NewGuid()
            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            await _userManager.CreateAsync(user);  // Save user to the database

            // Act
            var result = await _userService.AssignToStudentOrTeacherAsync(user);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(teacher.Id, user.AppId);
            Assert.AreEqual(teacher.VerificationKey, user.VerificationKey);
            Assert.IsFalse(user.IsGuest);
        }

        [Test]
        public async Task AssignToStudentOrTeacherAsync_NoMatch_ReturnsFalse()
        {
            // Arrange
            var user = new ApplicationUser
            {
                IdNumber = "1122334455",
                FirstName = "testfirst",
                MiddleName = "testmiddle",
                LastName = "testlast",
                SecurityStamp = Guid.NewGuid().ToString()  // Setting SecurityStamp
            };

            await _userManager.CreateAsync(user);  // Save user to the database

            // Act
            var result = await _userService.AssignToStudentOrTeacherAsync(user);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddToRoleAsync_RoleDoesNotExist_CreatesRoleAndAddsToUser_ReturnsTrue()
        {
            // Arrange
            var user = new ApplicationUser 
            { 
                UserName = "testuser20",
                FirstName = "testfirst20",
                MiddleName = "testmiddle20",
                LastName = "testlast20",
                IdNumber = "2020202020",
                SecurityStamp = Guid.NewGuid().ToString()  // Setting SecurityStamp
            };
            var roleName = "TestRole20";

            await _userManager.CreateAsync(user);  // Save user to the database

            // Act
            var result = await _userService.AddToRoleAsync(user, roleName);

            // Assert
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            Assert.IsTrue(roleExists);
            var userRoles = await _userManager.GetRolesAsync(user);
            Assert.Contains(roleName, userRoles.ToList());
        }

        [Test]
        public async Task AddToRoleAsync_RoleExists_AddsToUser_ReturnsTrue()
        {
            // Arrange
            var user = new ApplicationUser 
            { 
                UserName = "testuser", 
                FirstName = "testfirst10",
                MiddleName = "testmiddle10",
                LastName = "testlast10",
                IdNumber = "1010101010",
                SecurityStamp = Guid.NewGuid().ToString()  // Setting SecurityStamp
            };
            var roleName = "TestRole10";

            var role = new IdentityRole<Guid>(roleName);
            await _roleManager.CreateAsync(role);

            await _userManager.CreateAsync(user);  // Save user to the database

            // Act
            var result = await _userService.AddToRoleAsync(user, roleName);

            // Assert
            var userRoles = await _userManager.GetRolesAsync(user);
            Assert.Contains(roleName, userRoles.ToList());
        }
    }
}
