using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class MembershipStatusResponse
{
	[JsonProperty("is_member")]
	public bool IsMember { get; set; }

	[JsonProperty("expiry_time")]
	public DateTime? ExpiryTime { get; set; }
}
