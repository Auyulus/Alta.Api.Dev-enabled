using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class WebsocketResponseBody
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("event")]
	public string Event { get; set; }

	[JsonProperty("key")]
	public string Key { get; set; }

	[JsonProperty("content")]
	public string Content { get; set; }

	[JsonProperty("responseCode")]
	public int ResponseCode { get; set; }
}
