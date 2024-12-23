using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class InstanceInfo
{
	[JsonProperty("instance_name")]
	public string InstanceName { get; set; }

	[JsonProperty("server_id")]
	public int? ServerIdentifier { get; set; }

	[JsonProperty("pod_status")]
	public string PodStatus { get; set; }

	[JsonProperty("region")]
	public string Region { get; set; }

	[JsonProperty("fleet")]
	public string FleetName { get; set; }

	[JsonProperty("image")]
	public string Image { get; set; }
}
