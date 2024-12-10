namespace SchoolManagementSystem.Web.ViewModels;

public class TeacherAdminViewModel
{
    public Guid TeacherId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string ValidationKey { get; set; } = string.Empty;
}