using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GiftResult
{
	[JsonProperty("status")]
	public GiftResultType Result { get; set; }

	[JsonProperty("transaction_id")]
	public int? TransactionIdentifier { get; set; }

	[JsonProperty("itemInfo ")]
	public ShopItemIdentifier ItemInfo { get; set; }
}
