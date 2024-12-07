using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;
using static SchoolManagementSystem.Common.EntityConstants.SchoolConstants;

namespace SchoolManagementSystem.Data.Models;

public class School
{
    public School()
    {
        Classes = new List<Class>();
        Teachers = new List<Teacher>();
        SchoolsProjects = new List<SchoolProject>();
    }
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = null!;
    
    [Required]
    [MaxLength(AddressMaxLength)]
    public string Address { get; set; } = null!;
    
    [MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }
    
    [Required]
    public string LogoUrl { get; set; } = string.Empty;

    [Required]
    public ICollection<Speciality> Specialities { get; set; }
    public ICollection<Class> Classes { get; set; }
    public ICollection<Teacher> Teachers { get; set; }
    public ICollection<SchoolProject> SchoolsProjects { get; set; }
}