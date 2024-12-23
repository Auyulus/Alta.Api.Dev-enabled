using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class PortConfig
{
	[JsonProperty("port")]
	public int Port { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}
