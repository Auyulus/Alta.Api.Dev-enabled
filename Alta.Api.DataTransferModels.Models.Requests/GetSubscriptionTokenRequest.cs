using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GetSubscriptionTokenRequest
{
	[JsonProperty("plan_external_id")]
	public string SubscriptionPlanIdentifier { get; set; }
}
