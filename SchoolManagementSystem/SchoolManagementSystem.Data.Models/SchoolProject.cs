namespace SchoolManagementSystem.Data.Models;

public class SchoolProject
{
    public int SchoolId { get; set; }
    public School School { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}