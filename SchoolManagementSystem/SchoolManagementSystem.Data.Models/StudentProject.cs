using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data.Models;

[PrimaryKey(nameof(StudentId), nameof(ProjectId))]
public class StudentProject
{
    [Required]
    public Guid StudentId { get; set; }
    [ForeignKey(nameof(StudentId))]
    public Student Student { get; set; } = null!;
    
    [Required]
    public int ProjectId { get; set; }
    [ForeignKey(nameof(ProjectId))]
    public Project Project { get; set; } = null!;
}