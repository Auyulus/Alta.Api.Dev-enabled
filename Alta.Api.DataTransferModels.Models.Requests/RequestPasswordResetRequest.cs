using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class RequestPasswordResetRequest
{
	[JsonProperty("email")]
	public string Email { get; set; }

	public RequestPasswordResetRequest()
	{
	}

	public RequestPasswordResetRequest(string email)
	{
		Email = email;
	}
}
