using Alta.Api.DataTransferModels.Interfaces;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class TownshipItemCategory : IIdentifiable
{
	[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("enabled")]
	public bool Enabled { get; set; }

	[JsonProperty("parentCategory")]
	public TownshipItemCategory ParentCategory { get; set; }

	[JsonProperty("code")]
	public string Code { get; set; }
}
