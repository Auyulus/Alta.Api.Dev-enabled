using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class VersionMarker
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("version")]
	public GameVersion Version { get; set; }
}
