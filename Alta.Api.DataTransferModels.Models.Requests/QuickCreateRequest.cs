using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class QuickCreateRequest
{
	[JsonProperty("region")]
	public string LaunchRegion { get; set; }
}
