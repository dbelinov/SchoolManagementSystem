using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Web.ViewModels;

public class TeacherGradesViewModel
{
    public string StudentName { get; set; } = string.Empty;
    public ICollection<Grade> Grades { get; set; } = new List<Grade>(); 
}