using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopAccountInfo
{
	public class SubscriptionStatus
	{
		[JsonProperty("is_member")]
		public bool IsSupporter { get; set; }

		[JsonProperty("member_end_date")]
		public DateTime? MemberEndDate { get; set; }

		[JsonProperty("is_renewing")]
		public bool? IsRenewing { get; set; }

		[JsonProperty("next_reward")]
		public DateTime? NextReward { get; set; }
	}

	[JsonProperty("shard_balance")]
	public int ShardBalance { get; set; }

	[JsonProperty("wallet_amount")]
	public decimal WalletAmount { get; set; }

	[JsonProperty("wallet_currency")]
	public string WalletCurrency { get; set; }

	[JsonProperty("subscription_status")]
	public SubscriptionStatus MemberStatus { get; set; }
}
