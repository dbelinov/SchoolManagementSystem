namespace SchoolManagementSystem.Web.ViewModels;

public class StudentAdminViewModel
{
    public Guid StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
}