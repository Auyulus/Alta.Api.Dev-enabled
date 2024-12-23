using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class EditGroupRequest
{
	[JsonProperty("changing_servers")]
	public bool IsChangingServers { get; set; } = true;

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("tags")]
	public List<string> Tags { get; set; }

	[JsonProperty("visibility")]
	private GroupType? Visibility
	{
		set
		{
			Type = value;
		}
	}

	[JsonProperty("type")]
	public GroupType? Type { get; set; }
}
