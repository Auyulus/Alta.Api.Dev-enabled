using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class SocialMediaInfo
{
	[JsonProperty("icon")]
	public string Icon { get; set; }

	[JsonProperty("address")]
	public string Address { get; set; }
}
