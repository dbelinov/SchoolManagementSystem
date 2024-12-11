using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Tests;

[TestFixture]
public class SchoolServiceTests
{
    private ApplicationDbContext _context;
    private SchoolService _schoolService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _schoolService = new SchoolService(_context);

        SeedDatabase();
    }

    private void SeedDatabase()
    {
        _context.Schools.AddRange(new List<School>
        {
            new() { Id = 1, Name = "ABC School", Address = "123 Street", Description = "A good school", LogoUrl = "logo1.png" },
            new() { Id = 2, Name = "XYZ School", Address = "456 Avenue", Description = "A great school", LogoUrl = "logo2.png" },
            new() { Id = 3, Name = "LMN School", Address = "789 Road", Description = "An awesome school", LogoUrl = "logo3.png" }
        });

        _context.SaveChanges();
    }

    [Test]
    public void GetAllSchoolsAsync_ShouldReturnAllSchools()
    {
        var result = _schoolService.GetAllSchoolsAsync();

        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0].Name, Is.EqualTo("ABC School"));
        Assert.That(result[1].Name, Is.EqualTo("XYZ School"));
        Assert.That(result[2].Name, Is.EqualTo("LMN School"));
    }

    [Test]
    public async Task GetSchoolDetailsAsync_ShouldReturnCorrectSchool()
    {
        var result = await _schoolService.GetSchoolDetailsAsync(1);

        Assert.IsNotNull(result);
        Assert.That(result.Id, Is.EqualTo(1));
        Assert.That(result.Name, Is.EqualTo("ABC School"));
    }

    [Test]
    public async Task GetSchoolDetailsAsync_ShouldReturnNullIfSchoolNotFound()
    {
        var result = await _schoolService.GetSchoolDetailsAsync(99); 

        Assert.IsNull(result);
    }

    [Test]
    public void SearchSchools_ShouldReturnMatchingSchools()
    {
        var result = _schoolService.SearchSchools("XYZ", 1, 10);

        Assert.That(result.Count, Is.EqualTo(1)); 
        Assert.That(result[0].Name, Is.EqualTo("XYZ School"));
    }

    [Test]
    public void SearchSchools_ShouldReturnEmptyListIfNoMatch()
    {
        var result = _schoolService.SearchSchools("NotExist", 1, 10);

        Assert.That(result.Count, Is.EqualTo(0));
    }

    [TearDown]
    public void TearDown()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }
}