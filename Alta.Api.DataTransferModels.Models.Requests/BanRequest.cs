using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class BanRequest
{
	[JsonProperty("user_id")]
	public int UserIdentifier { get; set; }

	[JsonProperty("duration_hours")]
	public float DurationInHours { get; set; }

	[JsonProperty("type")]
	public BanType BanType { get; set; }

	[JsonProperty("servers")]
	public List<int> Servers { get; set; }

	[JsonProperty("method")]
	public BanMethod BanMethod { get; set; }

	[JsonProperty("reason")]
	public string Reason { get; set; }

	[JsonProperty("calling_user_id")]
	public int? CallingUserIdentifier { get; set; }
}
