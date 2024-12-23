using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemIdentifier
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("sku")]
	public string Sku { get; set; }

	public override string ToString()
	{
		return $"[ItemInfo Id:{Identifier}, Sku:{Sku}]";
	}
}
