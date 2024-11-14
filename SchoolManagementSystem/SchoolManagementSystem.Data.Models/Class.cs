using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Data.Models;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public Speciality Speciality { get; set; }
    public int TimetableId { get; set; }
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public Timetables Timetable { get; set; }
}