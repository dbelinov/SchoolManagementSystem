using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.ProjectConstants;
using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.ViewModels;

public class ProjectCreateViewModel
{
    [Required(ErrorMessage = ProjectNameRequired)]
    [StringLength(ProjectNameMaxLength, MinimumLength = ProjectNameMinLength, ErrorMessage = ProjectNameLength)]
    public string Name { get; set; } = null!;
    
    [Required(ErrorMessage = ProjectCapacityRequired)]
    public int Capacity { get; set; }
    
    [Required(ErrorMessage = ProjectStartDateRequired)]
    public DateTime StartDate { get; set; } = DateTime.Today;
    
    [Required(ErrorMessage = ProjectEndDateRequired)]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = DateFormat)]
    public DateTime EndDate { get; set; } = DateTime.Today;

    [Required]
    public int SchoolId { get; set; }

    public ICollection<ProjectAdminViewModel> AvailableProjects { get; set; } = new List<ProjectAdminViewModel>();
}