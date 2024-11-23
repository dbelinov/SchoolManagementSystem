using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class RegisterFormViewModel
{
    [Required(ErrorMessage = EmailRequired)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = PasswordRequired)]
    [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, 
        ErrorMessage = PasswordLengthError)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    
    [Required(ErrorMessage = ConfirmPasswordRequired)]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = PasswordMatchError)]
    public string ConfirmPassword { get; set; } = string.Empty;

    [Required(ErrorMessage = FirstNameRequired)]
    [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = InvalidFirstName)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = MiddleNameRequired)]
    [StringLength(MiddleNameMaxLength, MinimumLength = MiddleNameMinLength, ErrorMessage = InvalidMiddleName)]
    public string MiddleName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = LastNameRequired)]
    [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = InvalidLastName)]
    public string LastName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = BirthDateRequired)]
    [DataType(DataType.Date)]
    public string BirthDate { get; set; } = string.Empty;
    
    [Required(ErrorMessage = IdNumberRequired)]
    [StringLength(IdNumberLength, MinimumLength = IdNumberLength, ErrorMessage = IdNumberInvalid)]
    public string IdNumber { get; set; } = string.Empty;
}