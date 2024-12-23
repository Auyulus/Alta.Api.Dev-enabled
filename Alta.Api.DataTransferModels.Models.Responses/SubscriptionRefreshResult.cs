using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class SubscriptionRefreshResult
{
	public class Reward
	{
		[JsonProperty("type")]
		public string RewardType { get; set; }

		[JsonProperty("amount")]
		public int RewardAmount { get; set; }
	}

	[JsonProperty("comment")]
	public string Comment { get; set; } = "No rewards applied";

	[JsonProperty("rewards")]
	public IEnumerable<Reward> Rewards { get; set; }

	[JsonProperty("reward_periods_passed")]
	public int RewardPeriodsPassed { get; set; }
}
