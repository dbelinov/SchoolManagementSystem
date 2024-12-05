using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data.Seeding;

public interface ISeeder
{
    Task SeedData(ModelBuilder modelBuilder);
}