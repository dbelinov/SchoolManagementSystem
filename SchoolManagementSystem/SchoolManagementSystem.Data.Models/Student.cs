using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementSystem.Data.Models;

using static SchoolManagementSystem.Common.EntityConstants.StudentConstants;

namespace SchoolManagementSystem.Data.Models;

public class Student
{
    public Student()
    {
        Id = Guid.NewGuid();
        VerificationKey = Guid.NewGuid();
        IsRegistered = false;
        Grades = new List<Grade>();
        StudentsProjects = new List<StudentProject>();
    }
    
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
    public int ClassId { get; set; }
    [ForeignKey(nameof(ClassId))]
    public Class Class { get; set; } = null!;

    public Guid VerificationKey { get; set; }
    
    [Required]
    public bool IsRegistered { get; set; }
    
    public ICollection<Grade> Grades { get; set; }
    public ICollection<StudentProject> StudentsProjects { get; set; }
}