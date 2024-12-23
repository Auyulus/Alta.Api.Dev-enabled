using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ServerSaveFileResponse
{
	[JsonProperty("urls")]
	public IEnumerable<string> Urls { get; set; }
}
