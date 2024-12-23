using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class SearchByUsernameRequest
{
	[JsonProperty("username")]
	public string Username { get; set; }
}
