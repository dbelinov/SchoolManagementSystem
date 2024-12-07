using SchoolManagementSystem.Common.Enums;

namespace SchoolManagementSystem.Web.ViewModels;

public class SchoolDetailsViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = null!;
    public string? Description { get; set; }
    public string? LogoUrl { get; set; } = string.Empty;
    public ICollection<Speciality> Specialities { get; set; } = new List<Speciality>();
}