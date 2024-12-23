using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopItemConfiguration
{
	[JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ItemSku { get; set; }

	[JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public decimal? DiscountPercentage { get; set; }

	[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Identifier { get; set; }

	[JsonProperty("shards", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? Shards { get; set; }

	[JsonProperty("promo", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Promo { get; set; }

	[JsonProperty("memberDiscount")]
	public bool IsSupporterOnlyDiscount { get; set; }
}
