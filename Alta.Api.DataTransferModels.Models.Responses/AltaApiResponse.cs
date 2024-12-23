using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class AltaApiResponse<T>
{
	[JsonProperty("data")]
	public IEnumerable<T> Data { get; }

	[JsonProperty("meta")]
	public QueryMeta Meta { get; }

	public AltaApiResponse(IEnumerable<T> data, QueryMeta meta)
	{
		Data = data;
		Meta = meta;
	}
}
