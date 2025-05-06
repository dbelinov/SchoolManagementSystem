namespace SchoolManagementSystem.Web.ViewModels.Teacher;

public class TeacherAdminViewModel
{
    public Guid TeacherId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string ValidationKey { get; set; } = string.Empty;
    public bool IsRegistered { get; set; }
}