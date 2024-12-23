using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class UnlinkAccountRequest
{
	[JsonProperty("user_id")]
	public int? UserIdentifier { get; set; }
}
