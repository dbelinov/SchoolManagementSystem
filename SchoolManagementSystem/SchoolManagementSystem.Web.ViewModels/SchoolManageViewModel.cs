using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.SchoolConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class SchoolManageViewModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = SchoolNameRequired)]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = SchoolNameLength)]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = SchoolAddressRequired)]
    [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = SchoolAddressLength)]
    public string Address { get; set; } = string.Empty;

    [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = SchoolDescriptionLength)]
    public string? Description { get; set; }
    
    [Required(ErrorMessage = SchoolLogoUrlRequired)]
    public string LogoUrl = string.Empty;

    public ICollection<ClassViewModel> Classes { get; set; } = new List<ClassViewModel>();
}