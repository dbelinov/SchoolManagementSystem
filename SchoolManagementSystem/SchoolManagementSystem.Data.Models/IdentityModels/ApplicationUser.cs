using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Data.Models.IdentityModels;

public class ApplicationUser : IdentityUser<Guid>
{
    public Guid VerificationKey { get; set; } = Guid.NewGuid();
    public Guid AppId { get; set; } = Guid.Empty;
    
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}