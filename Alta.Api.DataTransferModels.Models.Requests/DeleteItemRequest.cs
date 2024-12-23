using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class DeleteItemRequest
{
	[JsonProperty("item_id")]
	public int ItemIdentifier { get; set; }
}
