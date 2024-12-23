using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GetShardsTokenRequest
{
	[JsonProperty("shards_package_id")]
	public int ShardsPackageIdentifier { get; set; }

	[JsonProperty("quantity")]
	public int Quantity { get; set; } = 1;
}
