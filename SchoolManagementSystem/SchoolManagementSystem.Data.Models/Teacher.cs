using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;

using static SchoolManagementSystem.Common.EntityConstants.TeacherConstants;

namespace SchoolManagementSystem.Data.Models;

public class Teacher
{
    public Teacher()
    {
        Id = Guid.NewGuid();
        VerificationKey = Guid.NewGuid();
        IsRegistered = false;
        TeachersClasses = new List<TeacherClass>();
        Grades = new List<Grade>();
    }
    
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(MiddleNameMaxLength)]
    public string MiddleName { get; set; } = null!;
    
    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; } = null!;

    [Required]
    [MaxLength(IdNumberMaxLength)]
    public string IdNumber { get; set; } = null!;
    
    [Required]
    public Subject Subject { get; set; }
    
    [Required]
    public Guid VerificationKey { get; set; }

    [Required]
    public bool IsRegistered { get; set; }
    
    public ICollection<Grade> Grades { get; set; }
    public ICollection<TeacherClass> TeachersClasses { get; set; }
}