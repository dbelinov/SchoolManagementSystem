namespace SchoolManagementSystem.Common.ErrorMessages;

public static class AuthenticationErrorMessages
{
    public const string KeyIsRequired = "Authentication key is required!";
    public const string InvalidValidationKey = "Invalid validation key!";
    public const string NotLoggedIn = "Not logged in!";
    public const string PasswordLengthError = "Password must be between 6 and 100 characters long!";
    public const string PasswordMatchError = "Password don't match!";
    public const string IdNumberInvalid = "Invalid id!";
    public const string InvalidFirstName = "First name should be between 2 and 10 characters!";
    public const string InvalidMiddleName = "Middle name should be between 2 and 10 characters!";
    public const string InvalidLastName = "Last name should be between 2 and 20 characters!";
    public const string EmailRequired = "Email is required!";
    public const string PasswordRequired = "Password is required!";
    public const string ConfirmPasswordRequired = "Confirm password is required!";
    public const string IdNumberRequired = "Identification Number is required!";
    public const string FirstNameRequired = "First name is required!";
    public const string MiddleNameRequired = "Middle name is required!";
    public const string LastNameRequired = "Last name is required!";
    public const string SchoolRequired = "School is required!";
    public const string SchoolNameRequired = "School name is required!";
    public const string ProjectNameRequired = "Project name is required!";
    public const string ProjectCapacityRequired = "Project capacity is required!";
    public const string ProjectStartDateRequired = "Project start date is required!";
    public const string ProjectEndDateRequired = "Project end date is required!";
    public const string SchoolAddressRequired = "School address is required!";
    public const string SchoolLogoUrlRequired = "School logo url is required!";
    public const string SchoolNameLength = "School name should be between 2 and 100 characters!";
    public const string ProjectNameLength = "Project name should be between 5 and 50 characters!";
    public const string SchoolAddressLength = "School address should be between 10 and 150 characters!";
    public const string SchoolDescriptionLength = "School description should be between 10 and 500 characters!";
    public const string ClassRequired = "Class is required!";
    public const string SpecialityRequired = "Speciality is required!";
    public const string BirthDateRequired = "Birth date is required!";
    public const string InvalidBirthDate = "Invalid birth date!";
    public const string InvalidUser = "No such person in the database!";
    public const string NotAuthenticated = "User not authenticated!";
}