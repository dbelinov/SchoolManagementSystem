using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Services.Contracts;

public interface ITeacherService
{
    Task<TeacherDashboardViewModel?> GetDashboardAsync(string userId);
    Task<TeacherClassesViewModel?> GetGradesDashboardAsync(string userId);
    Task<List<TeacherGradesViewModel>?> GetClassGradesAsync(int classId, string userId);
    Task<int?> AddGradeAsync(int gradeValue, Guid studentId, string userId);
    Task<int?> DeleteGradeAsync(int gradeId, Guid studentId, string userId);
}