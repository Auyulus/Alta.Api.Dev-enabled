using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class CreateGroupServerRequest
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("region")]
	public string LaunchRegion { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }
}
