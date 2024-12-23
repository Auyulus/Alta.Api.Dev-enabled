using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ItemSetRequest
{
	[JsonProperty("set_item")]
	public ShopItemDetailed SetItem { get; set; }

	[JsonProperty("items")]
	public IEnumerable<int> Items { get; set; }

	[JsonProperty("type")]
	public ItemSetType Type { get; set; }
}
