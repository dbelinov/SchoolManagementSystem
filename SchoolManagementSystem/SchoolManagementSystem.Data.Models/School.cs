namespace SchoolManagementSystem.Data.Models;

public class School
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<Class> Classes { get; set; } = new List<Class>();
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    public ICollection<SchoolProject> SchoolsProjects { get; set; } = new List<SchoolProject>();
}