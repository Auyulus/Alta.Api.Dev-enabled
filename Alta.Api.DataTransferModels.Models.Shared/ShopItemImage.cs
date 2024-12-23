using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemImage
{
	[JsonProperty("url")]
	public string Url { get; set; }

	[JsonProperty("width")]
	public int Width { get; set; }

	[JsonProperty("height")]
	public int Height { get; set; }

	[JsonProperty("formatType", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string FormatType { get; set; }

	[JsonProperty("formats", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public List<ShopItemImage> Formats { get; set; }

	[JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ImageType { get; set; }
}
