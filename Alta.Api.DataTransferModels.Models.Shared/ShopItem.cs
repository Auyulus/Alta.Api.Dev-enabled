using Alta.Api.DataTransferModels.Helpers;
using Alta.Api.DataTransferModels.Interfaces;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItem : IIdentifiable
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("sku")]
	public string Sku { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("price")]
	public ShopPrice Price { get; set; }

	[JsonProperty("only_buy_once")]
	public bool CanOnlyBeBoughtOnce { get; set; } = true;

	[JsonProperty("is_set")]
	public bool IsSet => ShopHelper.IsItemSet(Sku);

	[JsonProperty("purchaseCount")]
	public int PurchaseCount { get; set; }

	public bool IsEnabled { get; set; }

	public override string ToString()
	{
		return Id + " - " + Sku;
	}
}
