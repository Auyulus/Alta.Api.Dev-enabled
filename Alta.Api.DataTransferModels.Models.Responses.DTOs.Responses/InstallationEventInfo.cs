using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses.DTOs.Responses;

public class InstallationEventInfo
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("time")]
	public DateTime Time { get; set; }

	[JsonProperty("type")]
	public string EventType { get; set; }

	[JsonProperty("version_to")]
	public string VersionTo { get; set; }

	[JsonProperty("version_from")]
	public string VersionFrom { get; set; }

	[JsonProperty("user_id")]
	public int UserIdentifier { get; set; }

	[JsonProperty("start_id")]
	public int StartIdentifier { get; set; }

	[JsonProperty("error")]
	public string Error { get; set; }
}
