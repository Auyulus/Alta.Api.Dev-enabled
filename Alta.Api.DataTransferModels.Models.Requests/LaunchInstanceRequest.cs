using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LaunchInstanceRequest
{
	[JsonProperty("server_id")]
	public int ServerIdentifier { get; set; }

	[JsonProperty("version")]
	public string Version { get; set; } = "latest";

	[JsonProperty("extra_args")]
	public string[] ExtraArguments { get; set; }

	[JsonProperty("is_wiping")]
	public bool IsWiping { get; set; }

	[JsonProperty("start_shell")]
	public bool StartShell { get; set; }
}
