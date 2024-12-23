using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LoginRequestBase : RefreshRequest
{
	[JsonProperty("password_hash")]
	public string PasswordHash { get; private set; }

	public LoginRequestBase(string passwordHash, string deviceIdentifier)
	{
		base.DeviceIdentifier = deviceIdentifier;
		PasswordHash = passwordHash;
	}

	public LoginRequestBase()
	{
	}
}
