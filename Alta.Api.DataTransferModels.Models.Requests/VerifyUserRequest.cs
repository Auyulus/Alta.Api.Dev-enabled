using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class VerifyUserRequest
{
	[JsonProperty("verification_token")]
	public string VerificationToken { get; set; }

	public VerifyUserRequest(string verificationToken)
	{
		VerificationToken = verificationToken;
	}

	public VerifyUserRequest()
	{
	}
}
