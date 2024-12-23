using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GroupRoleInfo
{
	public const int BannedRoleIdentifier = 0;

	public const int DefaultRoleIdentifier = 1;

	public const int DefaultModeratorIdentifier = 2;

	public const int OwnerRoleIdentifier = 7;

	[JsonProperty("role_id")]
	public int Identifier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("color")]
	public string Color { get; set; }

	[JsonProperty("permissions")]
	public GroupPermissions[] Permissions { get; set; }

	[JsonProperty("allowed_commands")]
	public string[] AllowedCommands { get; set; }
}
