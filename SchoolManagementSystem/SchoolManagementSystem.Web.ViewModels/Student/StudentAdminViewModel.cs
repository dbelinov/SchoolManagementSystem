namespace SchoolManagementSystem.Web.ViewModels.Student;

public class StudentAdminViewModel
{
    public Guid StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string SchoolName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string ValidationKey { get; set; } = string.Empty;
    public bool IsRegistered { get; set; }
}