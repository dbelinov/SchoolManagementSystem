namespace SchoolManagementSystem.Data.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Capacity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<SchoolProject> SchoolsProjects { get; set; } = new List<SchoolProject>();
    public ICollection<StudentProject> StudentsProjects { get; set; } = new List<StudentProject>();
}