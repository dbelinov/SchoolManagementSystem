using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services;

public class HomeService : IHomeService
{
    private readonly ApplicationDbContext _context;

    public HomeService(ApplicationDbContext context)
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
}