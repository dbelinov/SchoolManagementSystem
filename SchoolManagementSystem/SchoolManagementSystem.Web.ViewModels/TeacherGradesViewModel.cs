using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Web.ViewModels;

public class TeacherGradesViewModel
{
    public Guid StudentId { get; set; }
    public string StudentName { get; set; } = string.Empty;
    public ICollection<Grade> Grades { get; set; } = new List<Grade>(); 
}