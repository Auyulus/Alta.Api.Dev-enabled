using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ShopItemsRequest
{
	[JsonProperty("items")]
	public IEnumerable<int> Items { get; set; }
}
