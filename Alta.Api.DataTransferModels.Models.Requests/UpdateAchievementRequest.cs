using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class UpdateAchievementRequest
{
	[JsonProperty("hash")]
	public uint AchievementHash { get; set; }

	[JsonProperty("completed")]
	public bool IsCompleted { get; set; }
}
