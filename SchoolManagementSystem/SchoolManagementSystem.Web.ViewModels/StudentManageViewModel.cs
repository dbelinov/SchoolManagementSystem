using System.ComponentModel.DataAnnotations;

using static SchoolManagementSystem.Common.EntityConstants.StudentConstants;

namespace SchoolManagementSystem.Web.ViewModels;

public class StudentManageViewModel
{
    [Required]
    [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [StringLength(MiddleNameMaxLength, MinimumLength = MiddleNameMinLength)]
    public string MiddleName { get; set; } = string.Empty;
    
    [Required]
    [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(IdNumberMaxLength, MinimumLength = IdNumberMinLength)]
    public string IdNumber { get; set; } = string.Empty;
    
    //TODO: Optimise for a student to be able to switch classes
    /*[Required]
    public string ClassId { get; set; } = string.Empty;*/
}