using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class StopInstanceRequest
{
	[JsonProperty("server_id")]
	public int ServerIdentifier { get; set; }
}
