using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PageResponse
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("queryResponses")]
	public List<QueryResponse> QueryResponses { get; set; }
}
