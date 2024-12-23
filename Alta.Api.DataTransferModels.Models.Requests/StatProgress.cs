using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class StatProgress
{
	[JsonProperty("hash")]
	public uint StatHash { get; set; }

	[JsonProperty("new_progress")]
	public float NewProgress { get; set; }

	[JsonProperty("progress")]
	public float Progress { get; set; }
}
