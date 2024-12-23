using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Transitions
{
	[JsonProperty("page_id")]
	public int PageId { get; set; }

	[JsonProperty("conditions")]
	public List<Condition> Conditions { get; set; }
}
