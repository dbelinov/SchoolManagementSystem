using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface ISchoolService
{
    Task<IEnumerable<SchoolViewModel>> GetAllSchoolsAsync();
    Task<SchoolDetailsViewModel?> GetSchoolDetailsAsync(int id);
}