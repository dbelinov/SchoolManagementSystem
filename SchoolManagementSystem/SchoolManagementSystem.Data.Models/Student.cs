namespace SchoolManagementSystem.Data.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Dictionary<string, List<int>> Grades { get; set; } =  new Dictionary<string, List<int>>();
    public int ClassId { get; set; }
    public Class Class { get; set; }
}