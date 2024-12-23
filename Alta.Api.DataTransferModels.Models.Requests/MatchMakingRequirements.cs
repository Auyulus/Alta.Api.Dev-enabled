using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class MatchMakingRequirements
{
	[JsonProperty("target")]
	public int? Target { get; set; }

	[JsonProperty("scene_index")]
	public int? SceneIndex { get; set; }
}
