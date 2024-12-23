using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class SubscriptionPlanInfo
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("external_id")]
	public string ExternalId { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("charge")]
	public ChargeInfo Charge { get; set; }

	[JsonProperty("trial")]
	public Duration Trial { get; set; }

	[JsonProperty("enabled")]
	public bool IsEnabled { get; set; }
}
