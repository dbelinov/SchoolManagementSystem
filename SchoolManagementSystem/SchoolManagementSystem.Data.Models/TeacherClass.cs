using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data.Models;

[PrimaryKey(nameof(TeacherId), nameof(ClassId))]
public class TeacherClass
{
    [Required]
    public Guid TeacherId { get; set; }
    [ForeignKey(nameof(TeacherId))]
    public Teacher Teacher { get; set; } = null!;
    
    [Required]
    public int ClassId { get; set; }
    [ForeignKey(nameof(ClassId))]
    public Class Class { get; set; } = null!;
}