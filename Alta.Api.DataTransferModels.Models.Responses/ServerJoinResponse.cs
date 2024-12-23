using System;
using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ServerJoinResponse
{
	[JsonProperty("allowed")]
	public bool IsAllowed { get; set; }

	[JsonProperty("ban_reason")]
	public string BanReason { get; set; }

	[JsonProperty("ban_end")]
	public DateTime BanEndTime { get; set; }

	[JsonProperty("ban_type")]
	public BanType BanType { get; set; }
}
