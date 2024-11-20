using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementSystem.Data.Models;

using static SchoolManagementSystem.Common.EntityConstants.StudentConstants;

namespace SchoolManagementSystem.Data.Models;

public class Student
{
    public Student()
    {
        StudentGrades = new List<StudentGrade>();
        StudentsProjects = new List<StudentProject>();
    }
    
    public int Id { get; set; }
    
    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; } = null!;
    
    [Required]
    public int ClassId { get; set; }
    [ForeignKey(nameof(ClassId))]
    public Class Class { get; set; } = null!;
    
    public ICollection<StudentGrade> StudentGrades { get; set; }
    public ICollection<StudentProject> StudentsProjects { get; set; }
}