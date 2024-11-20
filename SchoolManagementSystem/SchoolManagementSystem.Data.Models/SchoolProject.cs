using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data.Models;

[PrimaryKey(nameof(SchoolId), nameof(ProjectId))]
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