using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class TownshipItemCategoryModificationRequest : TownshipItemCategory
{
	[JsonProperty("parentCategory", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public new int ParentCategory { get; set; }
}
