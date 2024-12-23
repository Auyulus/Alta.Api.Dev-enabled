using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class CreateGroupRequest
{
	[JsonProperty("type")]
	public GroupType Type { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("Name")]
	public string Name { get; set; }
}
