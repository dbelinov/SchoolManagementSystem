namespace SchoolManagementSystem.Common.ErrorMessages;

public static class AuthenticationErrorMessages
{
    public const string KeyIsRequired = "Authentication key is required!";
    public const string InvalidValidationKey = "Invalid validation key!";
    public const string NotLoggedIn = "Not logged in!";
    public const string PasswordLengthError = "Password must be between 6 and 100 characters long!";
    public const string PasswordMatchError = "Password don't match!";
    public const string IdNumberInvalid = "Invalid id!";
}