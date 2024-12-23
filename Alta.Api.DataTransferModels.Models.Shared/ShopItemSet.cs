using System.Collections.Generic;
using Alta.Api.DataTransferModels.Interfaces;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemSet : IIdentifiable
{
	[JsonProperty("sku")]
	public string Sku { get; set; }

	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("items")]
	public IEnumerable<ShopItemIdentifier> Items { get; set; }

	[JsonProperty("type")]
	public ItemSetType Type { get; set; }
}
