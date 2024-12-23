using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class LauncherGameInfoFull : LauncherGameInfoShort
{
	[JsonProperty("blogAddress")]
	public string BlogAddress { get; set; }

	[JsonProperty("buildPath")]
	public string BuildPath { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("image")]
	public string Image { get; set; }

	[JsonProperty("logo")]
	public string Logo { get; set; }

	[JsonProperty("patchNotes")]
	public PatchNotes PatchNotes { get; set; }

	[JsonProperty("shop_config_url")]
	public string ShopConfigUrl { get; set; }

	[JsonProperty("socialMedia")]
	public List<SocialMediaInfo> SocialMedia { get; set; }

	[JsonProperty("versionMarkers")]
	public List<VersionMarker> VersionMarkers { get; set; }
}
