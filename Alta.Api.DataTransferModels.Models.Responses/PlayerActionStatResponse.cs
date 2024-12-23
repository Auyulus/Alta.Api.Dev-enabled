using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Requests;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PlayerActionStatResponse
{
	[JsonProperty("stats")]
	public List<StatProgress> ActionStats { get; set; }
}
