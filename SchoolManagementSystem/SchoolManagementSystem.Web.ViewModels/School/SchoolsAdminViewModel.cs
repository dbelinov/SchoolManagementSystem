namespace SchoolManagementSystem.Web.ViewModels;

public class SchoolsAdminViewModel
{
    public int SchoolId { get; set; }
    public string SchoolName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int Classes { get; set; }
}