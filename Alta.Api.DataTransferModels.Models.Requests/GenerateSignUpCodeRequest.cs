using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GenerateSignUpCodeRequest
{
	[JsonProperty("referral")]
	public string Referral { get; set; }

	[JsonProperty("campaign")]
	public string Campaign { get; set; }

	[JsonProperty("first_name")]
	public string FirstName { get; set; }

	[JsonProperty("last_name")]
	public string LastName { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }
}
