using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopPrice
{
	[JsonProperty("type")]
	public PriceType PriceType { get; set; } = PriceType.Shards;

	[JsonProperty("amount")]
	public decimal Amount { get; set; } = 1m;

	public ShopPrice Multiply(int quantity)
	{
		return new ShopPrice
		{
			PriceType = PriceType,
			Amount = Amount * (decimal)quantity
		};
	}
}
