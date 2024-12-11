using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;
using X.PagedList;
using X.PagedList.Extensions;

namespace SchoolManagementSystem.Services;

public class SchoolService : ISchoolService
{
    private readonly ApplicationDbContext _context;

    public SchoolService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IPagedList<SchoolViewModel> GetAllSchoolsAsync()  
        => _context.Schools
        .Select(s => new SchoolViewModel
        {
            Id = s.Id,
            Name = s.Name,
            Address = s.Address,
            Description = s.Description,
            LogoUrl = s.LogoUrl,
        })
        .ToPagedList();

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
          //      Specialities = s.Specialities
            })
            .FirstOrDefaultAsync();
    
    public IPagedList<SchoolViewModel> SearchSchools(string query, int pageNumber, int pageSize)
    {
        var schools = _context.Schools.AsQueryable();

        if (!string.IsNullOrEmpty(query))
        {
            schools = schools.Where(s => s.Name.Contains(query) ||
                                         s.Address.Contains(query));
        }

        var pagedList = schools.OrderBy(s => s.Name).Select(s => new SchoolViewModel
        {
            Id = s.Id,
            Name = s.Name,
            Address = s.Address,
            Description = s.Description,
            LogoUrl = s.LogoUrl
        }).ToPagedList(pageNumber, pageSize);

        return pagedList;
    }
}