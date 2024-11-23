using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class RegisterFormViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, 
        ErrorMessage = PasswordLengthError)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = PasswordMatchError)]
    public string ConfirmPassword { get; set; }
    
    [Required]
    [StringLength(IdNumberLength, MinimumLength = IdNumberLength, ErrorMessage = IdNumberInvalid)]
    public string IdNumber { get; set; }
}