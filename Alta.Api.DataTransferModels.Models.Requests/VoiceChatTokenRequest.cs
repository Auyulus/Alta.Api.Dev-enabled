using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class VoiceChatTokenRequest
{
	[JsonProperty("type")]
	public VoiceChatTokenRequestType Type { get; set; }

	[JsonProperty("server_id")]
	public int? ServerIdentifier { get; set; }
}
