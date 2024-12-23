using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class StartServerSessionResponse
{
	[JsonProperty("session_identifier")]
	public int ServerSession { get; set; }
}
