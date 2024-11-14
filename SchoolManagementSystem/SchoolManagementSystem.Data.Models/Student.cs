namespace SchoolManagementSystem.Data.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int ClassId { get; set; }
    public Class Class { get; set; }
    public ICollection<StudentGrade> StudentGrades { get; set; } =  new List<StudentGrade>();
    public ICollection<StudentProject> StudentsProjects { get; set; } = new List<StudentProject>();
}