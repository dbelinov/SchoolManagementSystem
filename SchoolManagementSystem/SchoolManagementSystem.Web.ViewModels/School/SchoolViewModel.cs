namespace SchoolManagementSystem.Web.ViewModels;

public class SchoolViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string? Description { get; set; }
    
    public string LogoUrl { get; set; } = string.Empty;
}