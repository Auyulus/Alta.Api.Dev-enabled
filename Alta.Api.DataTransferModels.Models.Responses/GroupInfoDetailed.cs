using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GroupInfoDetailed : GroupInfo
{
	[JsonProperty("servers")]
	public GroupServerInfo[] Servers { get; set; }

	[JsonProperty("allowed_servers_count")]
	public int AllowedServersCount { get; set; }

	[JsonProperty("roles")]
	public GroupRoleInfo[] Roles { get; set; }
}
