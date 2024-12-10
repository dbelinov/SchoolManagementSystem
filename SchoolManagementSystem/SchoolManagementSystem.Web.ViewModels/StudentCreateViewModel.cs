using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.StudentConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class StudentCreateViewModel
{
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
    
    public int SchoolId { get; set; }
    
    public int ClassId { get; set; }
    
    public ICollection<SchoolSelectViewModel> Schools { get; set; } = new List<SchoolSelectViewModel>();
    public ICollection<ClassViewModel> Classes { get; set; } = new List<ClassViewModel>();
}