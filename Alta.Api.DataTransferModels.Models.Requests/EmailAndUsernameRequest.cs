using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class EmailAndUsernameRequest
{
	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }
}
