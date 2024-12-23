using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ChargeInfo
{
	[JsonProperty("amount")]
	public decimal Amount { get; set; }

	[JsonProperty("period")]
	public Duration Period { get; set; }
}
