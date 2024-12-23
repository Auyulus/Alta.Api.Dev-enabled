using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class CreateGroupAndServerRequest : QuickCreateRequest
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("type")]
	public GroupType? GroupType { get; set; }

	[JsonProperty("target")]
	public int Target { get; set; }
}
