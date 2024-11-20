using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Data.Models.IdentityModels;

public class ApplicationUser : IdentityUser<Guid>
{
    public Guid VerificationKey { get; set; } = Guid.NewGuid();
    public Guid AppId { get; set; } = Guid.Empty;
    
    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(MiddleNameMaxLength)]
    public string MiddleName { get; set; } = null!;
    
    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; } = null!;
}