using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GiveRoleRequest
{
	[JsonProperty("role")]
	public AssignableRoles Role { get; set; }
}
