using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class QueryMeta
{
	[JsonProperty("offset")]
	public int Offset { get; }

	[JsonProperty("hasMoreResults")]
	public bool HasMoreResults { get; }

	[JsonProperty("count")]
	public int Results { get; set; }

	public QueryMeta(int offset, bool hasMoreResults)
	{
		Offset = offset;
		HasMoreResults = hasMoreResults;
	}
}
