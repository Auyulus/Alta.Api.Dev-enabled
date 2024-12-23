using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class VerificationEmailRequest
{
	[JsonProperty("email")]
	public string Email { get; set; }
}
