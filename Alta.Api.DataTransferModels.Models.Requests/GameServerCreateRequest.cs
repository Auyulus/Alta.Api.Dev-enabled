using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GameServerCreateRequest
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("scene_index")]
	public int SceneIndex { get; set; }

	[JsonProperty("region")]
	public string Region { get; set; }

	[JsonProperty("owner_type")]
	public ServerOwnerType OwnerType { get; set; }

	[JsonProperty("join_type")]
	public ServerJoinType JoinType { get; set; }

	[JsonProperty("group_id")]
	public int? GroupIdentifier { get; set; }

	[JsonProperty("fleet_name")]
	public string FleetName { get; set; } = "att-release";

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("access_policies")]
	public HashSet<string> AccessPolicies { get; set; } = new HashSet<string> { "server_access_pre_alpha" };
}
