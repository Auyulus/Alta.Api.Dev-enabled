using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class InstallationEventRequest
{
	[JsonProperty("type")]
	public string EventType { get; set; }

	[JsonProperty("version_to")]
	public string VersionTo { get; set; }

	[JsonProperty("version_from")]
	public string VersionFrom { get; set; }

	[JsonProperty("error")]
	public string Error { get; set; }

	[JsonProperty("start_id")]
	public int? StartIdentifier { get; set; }
}
