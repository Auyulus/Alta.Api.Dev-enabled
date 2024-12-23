using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Condition
{
	[JsonProperty("queryId")]
	public int QueryId { get; set; }

	[JsonProperty("whitelist")]
	public List<string> Whitelist { get; set; }

	[JsonProperty("blacklist")]
	public List<string> Blacklist { get; set; }
}
