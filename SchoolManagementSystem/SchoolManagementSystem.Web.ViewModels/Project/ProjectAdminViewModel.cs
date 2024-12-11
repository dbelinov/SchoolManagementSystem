namespace SchoolManagementSystem.Web.ViewModels;

public class ProjectAdminViewModel
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public int Capacity { get; set; }
    
    public string StartDate { get; set; } = string.Empty;
    
    public string EndDate { get; set; } = string.Empty;

    public int SchoolId { get; set; }
}