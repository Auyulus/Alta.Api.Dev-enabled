using Alta.Api.DataTransferModels.Helpers;
using Alta.Api.DataTransferModels.Interfaces;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class OwnedShopItem : IIdentifiable
{
	[JsonProperty("quantity")]
	public int Quantity { get; set; }

	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("sku")]
	public string Sku { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("is_set")]
	public bool IsSet => ShopHelper.IsItemSet(Sku);
}
