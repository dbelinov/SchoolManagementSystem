namespace SchoolManagementSystem.Web.ViewModels;

public class TeacherClassesViewModel
{
    public string TeacherName { get; set; } = string.Empty;
    public ICollection<ClassViewModel> Classes { get; set; } = new List<ClassViewModel>();
}