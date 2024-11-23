using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Data.Models.IdentityModels;

public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser()
    {
        VerificationKey = Guid.Empty;
        AppId = Guid.Empty;
        BirthDate = DateTime.Today;
    }
    public Guid VerificationKey { get; set; }
    public Guid AppId { get; set; }

    [Required(ErrorMessage = FirstNameRequired)]
    [MaxLength(FirstNameMaxLength, ErrorMessage = InvalidFirstName)]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = MiddleNameRequired)]
    [MaxLength(MiddleNameMaxLength, ErrorMessage = InvalidMiddleName)]
    public string MiddleName { get; set; } = null!;

    [Required(ErrorMessage = LastNameRequired)]
    [MaxLength(LastNameMaxLength, ErrorMessage = InvalidLastName)]
    public string LastName { get; set; } = null!;
    
    [Required(ErrorMessage = BirthDateRequired)]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = IdNumberRequired)]
    [MaxLength(IdNumberLength, ErrorMessage = IdNumberInvalid)]
    public string IdNumber { get; set; } = null!;

    public bool IsAuthenticated { get; set; } = false;

    public bool IsGuest { get; set; } = true;
}