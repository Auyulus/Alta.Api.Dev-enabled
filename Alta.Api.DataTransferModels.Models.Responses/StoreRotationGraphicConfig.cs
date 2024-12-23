using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class StoreRotationGraphicConfig
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("src")]
	public string Src { get; set; }

	[JsonProperty("brightness")]
	public double Brightness { get; set; }
}
