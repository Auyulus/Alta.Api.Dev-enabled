using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class EditGroupRoleRequest
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("color")]
	public string Color { get; set; }

	[JsonProperty("permissions")]
	public List<GroupPermissions> Permissions { get; set; }

	[JsonProperty("allowed_commands")]
	public List<string> AllowedCommands { get; set; }
}
