using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LoginRequest : LoginRequestBase
{
	[JsonProperty("username")]
	public string Username { get; private set; }

	public LoginRequest(string username, string passwordHash, string deviceIdentifier)
		: base(passwordHash, deviceIdentifier)
	{
		Username = username;
	}

	public LoginRequest()
	{
	}
}
