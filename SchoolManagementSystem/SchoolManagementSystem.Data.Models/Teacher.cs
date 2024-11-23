using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;

using static SchoolManagementSystem.Common.EntityConstants.TeacherConstants;

namespace SchoolManagementSystem.Data.Models;

public class Teacher
{
    public Teacher()
    {
        Id = Guid.NewGuid();
        TeachersClasses = new List<TeacherClass>();
    }
    
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(MiddleNameMaxLength)]
    public string MiddleName { get; set; }
    
    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(IdNumberMaxLength)]
    public string IdNumber { get; set; } = null!;
    
    [Required]
    public Subject Subject { get; set; }
    
    public ICollection<TeacherClass> TeachersClasses { get; set; }
}