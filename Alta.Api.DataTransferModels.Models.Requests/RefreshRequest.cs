using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class RefreshRequest
{
	[JsonProperty("device_id")]
	public string DeviceIdentifier { get; set; }

	[JsonProperty("target")]
	public int? Target { get; set; }
}
