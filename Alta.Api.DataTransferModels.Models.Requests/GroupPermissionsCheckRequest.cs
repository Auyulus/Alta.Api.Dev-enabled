using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class GroupPermissionsCheckRequest
{
	[JsonProperty("permissions")]
	public GroupPermissions[] Permissions { get; set; }
}
