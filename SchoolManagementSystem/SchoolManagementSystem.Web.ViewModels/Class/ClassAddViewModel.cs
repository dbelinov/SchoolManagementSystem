using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;

using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class ClassAddViewModel
{
    public ClassAddViewModel()
    {
        Specialities = Enum.GetNames<Speciality>().ToList();
    }

    [Required(ErrorMessage = ClassRequired)]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = SpecialityRequired)]
    public string Speciality { get; set; } = string.Empty;

    public int SchoolId { get; set; }

    public ICollection<string> Specialities { get; set; }
}