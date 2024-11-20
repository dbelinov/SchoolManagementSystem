using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Data.Models;

public class SchoolProject
{
    [Required]
    public int SchoolId { get; set; }
    [ForeignKey(nameof(SchoolId))]
    public School School { get; set; }
    
    [Required]
    public int ProjectId { get; set; }
    [ForeignKey(nameof(ProjectId))]
    public Project Project { get; set; }
}