using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PlayerReportInfo
{
	[JsonProperty("id")]
	public Guid Identifier { get; set; }

	[JsonProperty("server")]
	public GameServerInfoMinimal Server { get; set; }

	[JsonProperty("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("reporting_user")]
	public UserInfo ReportingUser { get; set; }

	[JsonProperty("reported_user")]
	public UserInfo ReportedUser { get; set; }

	[JsonProperty("acting_user")]
	public UserInfo ActingUser { get; set; }

	[JsonProperty("status")]
	public ReportStatus Status { get; set; }

	[JsonProperty("acted_at")]
	public DateTime? ActedAt { get; set; }

	[JsonProperty("type")]
	public ReportType Type { get; set; }
}
