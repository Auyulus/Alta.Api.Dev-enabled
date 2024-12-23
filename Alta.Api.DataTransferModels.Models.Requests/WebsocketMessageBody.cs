using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class WebsocketMessageBody
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("method")]
	public string Method { get; set; }

	[JsonProperty("path")]
	public string Path { get; set; }

	[JsonProperty("content")]
	public string Content { get; set; }

	[JsonProperty("authorization")]
	public string Authorization { get; set; }
}
