using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ResolveComment
{
	[JsonProperty("comment")]
	public string Comment { get; set; }

	[JsonProperty("resolved")]
	public bool IsResolved { get; set; }
}
