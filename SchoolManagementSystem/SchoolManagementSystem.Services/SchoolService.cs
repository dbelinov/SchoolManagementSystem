using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services;

public class SchoolService : ISchoolService
{
    private readonly ApplicationDbContext _context;

    public SchoolService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<SchoolViewModel>> GetAllSchoolsAsync()  
        => await _context.Schools
        .Select(s => new SchoolViewModel
        {
            Id = s.Id,
            Name = s.Name,
            Address = s.Address,
            Description = s.Description,
            LogoUrl = s.LogoUrl,
        })
        .ToListAsync();

    public async Task<SchoolDetailsViewModel?> GetSchoolDetailsAsync(int id) 
        => await _context.Schools
            .Where(s => s.Id == id)
            .Select(s => new SchoolDetailsViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                Description = s.Description,
                LogoUrl = s.LogoUrl,
            })
            .FirstOrDefaultAsync();
}