using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ModifyReportRequest
{
	[JsonProperty("status")]
	public ReportStatus Status { get; set; }
}
