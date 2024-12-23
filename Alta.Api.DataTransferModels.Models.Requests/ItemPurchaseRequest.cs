using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ItemPurchaseRequest : PurchaseRequest
{
	[JsonProperty("item_id")]
	public int ItemIdentifier { get; set; }
}
