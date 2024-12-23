using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class UserSubscription
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("plan_id")]
	public int PlanInfoIdentifier { get; set; }

	[JsonProperty("plan_external_id")]
	public string PlanExternalIdentifier { get; set; }

	[JsonProperty("date_create")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("date_end")]
	public DateTime? EndedAt { get; set; }

	[JsonProperty("date_next_charge")]
	public DateTime NextChargeAt { get; set; }

	[JsonProperty("date_last_charge")]
	public DateTime LastChargeAt { get; set; }

	[JsonProperty("status")]
	public UserSubscriptionInfoStatus Status { get; set; }

	[JsonProperty("comment")]
	public string Comment { get; set; }

	[JsonProperty("plan")]
	public SubscriptionPlanInfo PlanInfo { get; set; }
}
