using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class CreateReportRequest
{
	[JsonProperty("server_id")]
	public int Server { get; set; }

	[JsonProperty("reported_user_id")]
	public int ReportedUser { get; set; }

	[JsonProperty("type")]
	public ReportType Type { get; set; }
}
