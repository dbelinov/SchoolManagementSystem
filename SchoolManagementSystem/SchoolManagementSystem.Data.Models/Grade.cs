using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Data.Models;

public class Grade
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public Guid StudentId { get; set; }

    [Required]
    public Guid TeacherId { get; set; }
    
    [Required]
    public Subject Subject { get; set; }
    
    [Required]
    public int GradeValue { get; set; }
}