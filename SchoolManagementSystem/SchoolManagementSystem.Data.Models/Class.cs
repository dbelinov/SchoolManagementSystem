using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementSystem.Common.Enums;

using static SchoolManagementSystem.Common.EntityConstants.ClassConstants;
namespace SchoolManagementSystem.Data.Models;

public class Class
{
    public Class()
    {
        Students = new List<Student>();
        TeachersClasses = new List<TeacherClass>();
    }
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    public int SchoolId { get; set; }
    [ForeignKey(nameof(SchoolId))]
    public virtual School School { get; set; }
    
    [Required]
    public Speciality Speciality { get; set; }
    
    public int? TimetableId { get; set; }
    [ForeignKey(nameof(TimetableId))]
    public Timetable? Timetable { get; set; }
    
    public ICollection<Student> Students { get; set; }
    public ICollection<TeacherClass> TeachersClasses { get; set; }
}