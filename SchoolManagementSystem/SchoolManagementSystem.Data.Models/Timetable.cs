using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Data.Models;

public class Timetable
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public int Period { get; set; }

    [Required]
    public int SchoolId { get; set; }
    
    [Required]
    public int ClassId { get; set; }
}