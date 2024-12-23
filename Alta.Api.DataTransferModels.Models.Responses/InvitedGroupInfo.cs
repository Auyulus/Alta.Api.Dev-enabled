using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class InvitedGroupInfo : GroupInfoDetailed
{
	[JsonProperty("invited_at")]
	public DateTime InvitedAt { get; set; }
}
