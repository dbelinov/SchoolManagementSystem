using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Web.ViewModels;

public class StudentGradesViewModel
{
    public Subject Subject { get; set; }
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}