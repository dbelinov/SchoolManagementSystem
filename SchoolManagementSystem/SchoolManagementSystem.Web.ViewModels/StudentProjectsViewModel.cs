namespace SchoolManagementSystem.Web.ViewModels;

public class StudentProjectsViewModel
{
    public ICollection<ProjectViewModel> AllProjects { get; set; } = new List<ProjectViewModel>();
    public ICollection<ProjectViewModel> UserProjects { get; set; } = new List<ProjectViewModel>();
}