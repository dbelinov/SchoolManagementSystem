using Moq;
using SchoolManagementSystem.Data.Models.IdentityModels;
using SchoolManagementSystem.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SchoolManagementSystem.Tests
{
    [TestFixture]
    public class VerificationServiceTests
    {
        private Mock<UserManager<ApplicationUser>> _mockUserManager;
        private VerificationService _verificationService;

        [SetUp]
        public void SetUp()
        {
            _mockUserManager = new Mock<UserManager<ApplicationUser>>(
                new Mock<IUserStore<ApplicationUser>>().Object,
                null, null, null, null, null, null, null, null);
            _verificationService = new VerificationService(_mockUserManager.Object);
        }

        [Test]
        public async Task VerifyCodeAsync_UserIsNull_ReturnsFalse()
        {
            // Arrange
            ApplicationUser? user = null;
            string verificationKey = Guid.NewGuid().ToString();

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task VerifyCodeAsync_VerificationKeyIsNullOrEmpty_ReturnsFalse()
        {
            // Arrange
            var user = new ApplicationUser();
            string verificationKey = string.Empty;

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task VerifyCodeAsync_VerificationKeyIsNotAGuid_ReturnsFalse()
        {
            // Arrange
            var user = new ApplicationUser();
            string verificationKey = "NotAGuid";

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task VerifyCodeAsync_VerificationKeyDoesNotMatch_ReturnsFalse()
        {
            // Arrange
            var user = new ApplicationUser
            {
                VerificationKey = Guid.NewGuid()
            };
            string verificationKey = Guid.NewGuid().ToString();

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task VerifyCodeAsync_ValidVerificationKey_Succeeds()
        {
            // Arrange
            var user = new ApplicationUser
            {
                VerificationKey = Guid.NewGuid()
            };
            string verificationKey = user.VerificationKey.ToString();

            _mockUserManager.Setup(m => m.AddClaimAsync(user, It.IsAny<Claim>())).ReturnsAsync(IdentityResult.Success);
            _mockUserManager.Setup(m => m.UpdateAsync(user)).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsTrue(result);
            _mockUserManager.Verify(m => m.AddClaimAsync(user, It.IsAny<Claim>()), Times.Once);
            _mockUserManager.Verify(m => m.UpdateAsync(user), Times.Once);
        }

        [Test]
        public async Task VerifyCodeAsync_UserUpdateFails_ReturnsFalse()
        {
            // Arrange
            var user = new ApplicationUser
            {
                VerificationKey = Guid.NewGuid()
            };
            string verificationKey = user.VerificationKey.ToString();

            _mockUserManager.Setup(m => m.AddClaimAsync(user, It.IsAny<Claim>())).ReturnsAsync(IdentityResult.Success);
            _mockUserManager.Setup(m => m.UpdateAsync(user)).ReturnsAsync(IdentityResult.Failed());

            // Act
            var result = await _verificationService.VerifyCodeAsync(user, verificationKey);

            // Assert
            Assert.IsFalse(result);
        }
    }
}