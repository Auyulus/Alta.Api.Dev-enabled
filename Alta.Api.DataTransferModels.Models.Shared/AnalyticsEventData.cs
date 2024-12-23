using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class AnalyticsEventData
{
	[JsonProperty("time")]
	public DateTime Time { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("source")]
	public string Source { get; set; }

	[JsonProperty("user_id")]
	public int? UserIdentifier { get; set; }

	[JsonProperty("version")]
	public string Version { get; set; }

	[JsonProperty("ip_address")]
	public string IpAddress { get; set; }

	[JsonProperty("oculus_id")]
	public string OculusIdentifier { get; set; }

	[JsonProperty("eventType")]
	public string EventType { get; set; }

	[JsonProperty("metaData")]
	public Dictionary<string, object> Metadata { get; set; }
}
