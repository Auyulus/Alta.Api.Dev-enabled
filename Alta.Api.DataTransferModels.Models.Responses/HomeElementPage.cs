using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class HomeElementPage
{
	[JsonProperty("image")]
	public string Image { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
	public string Target { get; set; }
}
