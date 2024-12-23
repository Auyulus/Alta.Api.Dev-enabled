using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ItemDeleteRequest : ItemPurchaseRequest
{
	[JsonProperty("reason")]
	public string Reason { get; set; }
}
