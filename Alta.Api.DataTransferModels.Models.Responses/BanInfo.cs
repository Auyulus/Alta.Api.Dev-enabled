using System;
using System.Collections.Generic;
using System.Net;
using Alta.Api.DataTransferModels.Converters;
using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class BanInfo
{
	[JsonProperty("ban_id")]
	public int Identifier { get; set; }

	[JsonProperty("user_id")]
	public int? UserIdentifier { get; set; }

	[JsonProperty("ip_address")]
	[JsonConverter(typeof(IPAddressJsonConverter))]
	public IPAddress IpAddress { get; set; }

	[JsonProperty("reason")]
	public string Reason { get; set; }

	[JsonProperty("type")]
	public BanType BanType { get; set; }

	[JsonProperty("servers")]
	public List<int> Servers { get; set; }

	[JsonProperty("end_time")]
	public DateTime EndTime { get; set; }

	[JsonProperty("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("created_by")]
	public int CreatedBy { get; set; }

	[JsonProperty("device_id")]
	public string DeviceIdentifier { get; set; }
}
