using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class QuickCreateResponse
{
	[JsonProperty("group")]
	public GroupInfo Group { get; set; }

	[JsonProperty("server")]
	public GameServerInfo Server { get; set; }
}
