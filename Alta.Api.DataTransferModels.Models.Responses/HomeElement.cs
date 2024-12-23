using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class HomeElement
{
	[JsonProperty("component")]
	public string Component { get; set; }

	[JsonProperty("pages")]
	public HomeElementPage[] Pages { get; set; }

	[JsonProperty("image")]
	public string Image { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("target")]
	public string Target { get; set; }

	[JsonProperty("address")]
	public string Address { get; set; }

	[JsonProperty("initial")]
	public int? Initial { get; set; }

	[JsonProperty("limit")]
	public int? Limit { get; set; }
}
