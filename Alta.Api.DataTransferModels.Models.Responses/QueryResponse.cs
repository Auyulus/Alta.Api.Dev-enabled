using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class QueryResponse
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("values")]
	public List<string> Values { get; set; }
}
