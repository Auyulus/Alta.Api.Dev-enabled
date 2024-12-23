using System;
using Alta.Api.DataTransferModels.Models.Requests;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GroupMemberInfo
{
	[JsonProperty("group_id")]
	public int GroupIdentifier { get; set; }

	[JsonProperty("user_id")]
	public int UserIdentifier { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("bot")]
	public bool IsBot { get; set; }

	[JsonProperty("icon")]
	public int IconIndex { get; set; }

	[JsonProperty("permissions")]
	public SetGroupPermissionsRequest.OldGroupPermission Permissions { get; set; }

	[JsonProperty("role_id")]
	public int RoleIdentifier { get; set; }

	[JsonProperty("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("type")]
	public GroupMemberType Type { get; set; }

	[JsonIgnore]
	public UserInfo UserInfo => new UserInfo(UserIdentifier, Username);
}
