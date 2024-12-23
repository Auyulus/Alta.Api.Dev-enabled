using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ServerStatusRequest
{
	[JsonProperty("status")]
	public GameServerStatus Status { get; set; }
}
