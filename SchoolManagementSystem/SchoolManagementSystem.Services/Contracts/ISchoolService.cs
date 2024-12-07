using SchoolManagementSystem.Web.ViewModels;
using X.PagedList;

namespace SchoolManagementSystem.Services.Contracts;

public interface ISchoolService
{
    IPagedList<SchoolViewModel> GetAllSchoolsAsync();
    Task<SchoolDetailsViewModel?> GetSchoolDetailsAsync(int id);
    IPagedList<SchoolViewModel> SearchSchools(string query, int pageNumber, int pageSize);
}