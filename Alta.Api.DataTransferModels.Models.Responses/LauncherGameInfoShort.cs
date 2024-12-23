using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class LauncherGameInfoShort
{
	[JsonProperty("identifier")]
	public int Identifier { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("icon")]
	public string Icon { get; set; }

	[JsonProperty("stringIdentifier")]
	public string StringIdentifier { get; set; }

	[JsonProperty("displayOrder")]
	public int DisplayOrder { get; set; }

	[JsonProperty("bucketUrl")]
	public string BucketUrl { get; set; }
}
