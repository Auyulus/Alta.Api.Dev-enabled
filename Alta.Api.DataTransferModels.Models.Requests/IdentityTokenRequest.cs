using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class IdentityTokenRequest
{
	[JsonProperty("user_data")]
	public object UserData { get; set; }
}
