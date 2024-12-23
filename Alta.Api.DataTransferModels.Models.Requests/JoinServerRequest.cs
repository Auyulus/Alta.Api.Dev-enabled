using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class JoinServerRequest
{
	[JsonProperty("should_launch")]
	public bool ShouldLaunchServer { get; set; } = true;

	[JsonProperty("ignore_offline")]
	public bool IsIgnoringOffline { get; set; }

	[JsonProperty("version")]
	public GameVersion GameVersion { get; set; }

	[JsonProperty("token")]
	public string IdentityToken { get; set; }

	[JsonProperty("device_id")]
	public string DeviceIdentifier { get; set; }
}
