using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LoginWithEmailRequest : LoginRequestBase
{
	[JsonProperty("email")]
	public string Email { get; private set; }

	public LoginWithEmailRequest(string email, string passwordHash, string deviceIdentifier)
		: base(passwordHash, deviceIdentifier)
	{
		Email = email;
	}

	public LoginWithEmailRequest()
	{
	}
}
