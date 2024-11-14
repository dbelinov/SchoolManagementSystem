using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Data.Models;

public class StudentGrade
{
    public int StudentId { get; set; }
    public Subject Subject { get; set; }
    public int Grade { get; set; }
}