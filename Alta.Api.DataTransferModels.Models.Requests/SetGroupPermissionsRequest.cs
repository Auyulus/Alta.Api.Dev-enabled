using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class SetGroupPermissionsRequest
{
	[Flags]
	public enum OldGroupPermission
	{
		Member = 1,
		Moderator = 2,
		Admin = 4
	}

	[JsonProperty("permissions")]
	public OldGroupPermission Permissions { get; set; }
}
