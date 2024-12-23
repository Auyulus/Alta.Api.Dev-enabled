using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GroupRoleRequest
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("permissions")]
	public List<GroupPermissions> Permissions { get; set; }
}
