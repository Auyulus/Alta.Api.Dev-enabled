using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemDetailed : ShopItem
{
	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("category")]
	public ItemCategory Category { get; set; }

	[JsonProperty("xsollaItemId")]
	public int XsollaItemId { get; set; }

	[JsonProperty("images")]
	public List<ShopItemImage> Images { get; set; }
}
