using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Common.Enums;
using static SchoolManagementSystem.Common.EntityConstants.StudentConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class TeacherManageViewModel
{
    public TeacherManageViewModel()
    {
        Subjects = Enum.GetNames<Subject>().ToList();
    }
    
    [Required(ErrorMessage = FirstNameRequired)]
    [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = InvalidFirstName)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = MiddleNameRequired)]
    [StringLength(MiddleNameMaxLength, MinimumLength = MiddleNameMinLength, ErrorMessage = InvalidMiddleName)]
    public string MiddleName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = LastNameRequired)]
    [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = InvalidLastName)]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = IdNumberRequired)]
    [StringLength(IdNumberMaxLength, MinimumLength = IdNumberMinLength, ErrorMessage = IdNumberInvalid)]
    public string IdNumber { get; set; } = string.Empty;

    public string Subject { get; set; } = string.Empty;

    public List<string> Subjects { get; set; }
}