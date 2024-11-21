using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Web.ViewModels;

public class VerificationEntryViewModel
{
    [Required]
    public string VerificationKey { get; set; }
}