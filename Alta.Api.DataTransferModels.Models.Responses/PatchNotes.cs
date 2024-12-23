using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PatchNotes
{
	[JsonProperty("url")]
	public string Url { get; set; }

	[JsonProperty("version")]
	public GameVersion Version { get; set; }
}
