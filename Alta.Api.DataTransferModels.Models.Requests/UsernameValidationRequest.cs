using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class UsernameValidationRequest
{
	[JsonProperty("username")]
	public string Username { get; set; }
}
