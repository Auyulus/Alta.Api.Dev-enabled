using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class CreateCheckResponse
{
	[Obsolete]
	[JsonProperty("value")]
	public bool Value { get; set; }

	[JsonProperty("pc_left")]
	public int PcGroupsLeft { get; set; }

	[JsonProperty("quest_left")]
	public int QuestGroupsLeft { get; set; }
}
