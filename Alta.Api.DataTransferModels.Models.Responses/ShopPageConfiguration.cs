using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopPageConfiguration
{
	[JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
	public string Subtitle { get; set; }

	[JsonProperty("primary")]
	public List<ShopItemConfiguration> PrimaryItems { get; set; }

	[JsonProperty("secondary")]
	public List<ShopItemConfiguration> SecondaryItems { get; set; }

	[JsonProperty("graphics", NullValueHandling = NullValueHandling.Ignore)]
	public List<StoreRotationGraphicConfig> Graphics { get; set; }

	[JsonIgnore]
	public IEnumerable<ShopItemConfiguration> AllItemConfigurations
	{
		get
		{
			foreach (ShopItemConfiguration primaryItem in PrimaryItems)
			{
				yield return primaryItem;
			}
			foreach (ShopItemConfiguration secondaryItem in SecondaryItems)
			{
				yield return secondaryItem;
			}
		}
	}
}
