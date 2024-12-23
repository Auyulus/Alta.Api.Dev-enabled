using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class SpecPortConfig
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("portPolicy")]
	public string PortPolicy { get; set; }

	[JsonProperty("hostPort")]
	public int HostPort { get; set; }

	[JsonProperty("containerPort")]
	public int ContainerPort { get; set; }
}
