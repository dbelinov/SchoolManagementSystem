using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface IHomeService
{
    Task<IEnumerable<SchoolViewModel>> GetAllSchoolsAsync();
}