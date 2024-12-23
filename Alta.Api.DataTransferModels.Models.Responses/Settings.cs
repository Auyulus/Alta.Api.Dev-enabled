using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Settings
{
	[JsonProperty("id")]
	public string Identifier { get; set; }

	[JsonProperty("content")]
	public string Content { get; set; }
}
