using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data.Seeding;

public interface ISeeder
{
    void SeedData(ApplicationDbContext context);
}