using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class BufferChangeRequest
{
	[JsonProperty("fleet")]
	public string Fleet { get; set; }

	[JsonProperty("region")]
	public string Region { get; set; }

	[JsonProperty("increase")]
	public int Increase { get; set; }
}
