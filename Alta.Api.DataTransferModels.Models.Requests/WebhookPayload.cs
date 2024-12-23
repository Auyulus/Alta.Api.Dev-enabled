using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class WebhookPayload
{
	[JsonProperty("message")]
	public string Message { get; set; }
}
