using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.ProjectConstants;

namespace SchoolManagementSystem.Data.Models;

public class Project
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(ProjectNameMaxLength)]
    public string Name { get; set; } = null!;
    
    [Required]
    public int Capacity { get; set; }
    
    [Required]
    public DateTime StartDate { get; set; }
    
    [Required]
    public DateTime EndDate { get; set; }
    
    public ICollection<SchoolProject> SchoolsProjects { get; set; } = new List<SchoolProject>();
    public ICollection<StudentProject> StudentsProjects { get; set; } = new List<StudentProject>();
}