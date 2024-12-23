using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PlayerAchievementResponse
{
	[JsonProperty("hashes")]
	public IEnumerable<uint> AchievementHashes { get; set; }
}
