using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Data.Models;

public class Teacher
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Subject Subject { get; set; }
}