using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GroupServerInfo
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("scene_index")]
	public int SceneIndex { get; set; }

	[JsonProperty("status")]
	[JsonConverter(typeof(StringEnumConverter))]
	public GameServerStatus Status { get; set; }
}
