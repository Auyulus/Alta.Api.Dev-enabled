namespace Alta.Api.DataTransferModels.Settings;

public static class NamingSettings
{
	public const string NameRegularExpression = "[a-zA-Z ]*";

	public const int NameLength = 100;

	public const string UsernameFieldName = "username";

	public const int PasswordHashLength = 500;

	public const int EmailLength = 500;

	public const int SignupCodeLength = 100;

	public const string SignupCodeRegularExpression = "[a-zA-Z0-9]*";
}
