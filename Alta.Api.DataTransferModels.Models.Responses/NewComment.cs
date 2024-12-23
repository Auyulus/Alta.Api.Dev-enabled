using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class NewComment
{
	[JsonProperty("comment")]
	public string Comment { get; set; }

	[JsonProperty("hidden")]
	public bool IsHidden { get; set; }
}
