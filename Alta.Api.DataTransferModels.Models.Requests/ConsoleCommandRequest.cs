using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ConsoleCommandRequest
{
	[JsonProperty("command")]
	public string Command { get; set; }
}
