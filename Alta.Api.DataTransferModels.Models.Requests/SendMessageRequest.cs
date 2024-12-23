using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class SendMessageRequest
{
	[JsonProperty("message")]
	public string Message { get; set; }

	[JsonProperty("userIds")]
	public List<int> UserIds { get; set; }
}
