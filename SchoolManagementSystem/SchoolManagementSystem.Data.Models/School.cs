using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.SchoolConstants;

namespace SchoolManagementSystem.Data.Models;

public class School
{
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
    
    public ICollection<Class> Classes { get; set; } = new List<Class>();
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    public ICollection<SchoolProject> SchoolsProjects { get; set; } = new List<SchoolProject>();
}