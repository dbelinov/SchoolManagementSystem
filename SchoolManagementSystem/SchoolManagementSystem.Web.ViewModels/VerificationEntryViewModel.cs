using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class VerificationEntryViewModel
{
    [Required(ErrorMessage = KeyIsRequired)]
    public string VerificationKey { get; set; } = null!;
}