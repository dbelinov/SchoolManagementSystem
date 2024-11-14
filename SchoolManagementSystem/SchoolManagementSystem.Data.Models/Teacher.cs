using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Data.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Subject Subject { get; set; }
    public ICollection<TeacherClass> TeachersClasses { get; set; } =  new List<TeacherClass>();
}