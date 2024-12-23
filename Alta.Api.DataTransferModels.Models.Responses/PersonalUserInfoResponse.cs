using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PersonalUserInfoResponse : PublicUserInfoResponse
{
	[JsonProperty("first_name")]
	public string FirstName { get; set; }

	[JsonProperty("last_name")]
	public string LastName { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }
}
