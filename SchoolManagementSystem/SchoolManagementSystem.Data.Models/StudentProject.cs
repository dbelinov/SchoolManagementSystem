namespace SchoolManagementSystem.Data.Models;

public class StudentProject
{
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}