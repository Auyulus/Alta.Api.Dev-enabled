using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GameHomeConfiguration
{
	[JsonProperty("elements")]
	public HomeElement[] Elements { get; set; }
}
