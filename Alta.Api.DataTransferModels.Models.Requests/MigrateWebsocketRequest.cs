using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class MigrateWebsocketRequest
{
	[JsonProperty("token")]
	public string Token { get; set; }
}
