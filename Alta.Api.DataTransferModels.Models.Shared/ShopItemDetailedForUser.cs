using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemDetailedForUser : ShopItemDetailed
{
	[JsonProperty("is_owned")]
	public bool IsOwned { get; set; }

	[JsonProperty("final_price")]
	public decimal FinalPrice { get; set; }
}
