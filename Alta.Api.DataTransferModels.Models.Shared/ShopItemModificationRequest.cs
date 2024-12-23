using Alta.Api.DataTransferModels.Helpers;
using Alta.Api.DataTransferModels.Interfaces;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemModificationRequest : IIdentifiable
{
	[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Id { get; set; }

	[JsonProperty("sku")]
	public string Sku { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("price")]
	public decimal Price { get; set; }

	[JsonProperty("canBuyOnlyOnce")]
	public bool CanOnlyBeBoughtOnce { get; set; } = true;

	[JsonProperty("isItemSet")]
	public bool IsItemSet => ShopHelper.IsItemSet(Sku);

	[JsonProperty("purchaseCount")]
	public int PurchaseCount { get; set; }

	[JsonProperty("isEnabled")]
	public bool IsEnabled { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("category")]
	public int Category { get; set; }

	[JsonProperty("xsollaItemId")]
	public int XsollaItemId { get; set; }

	[JsonProperty("currency")]
	public string Currency { get; set; }

	[JsonProperty("shopItemSet", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int ShopItemSet { get; set; }

	public override string ToString()
	{
		return Id + " - " + Sku;
	}
}
