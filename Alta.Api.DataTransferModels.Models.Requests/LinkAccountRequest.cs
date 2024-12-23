using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LinkAccountRequest : AccountRequestBase
{
	[JsonProperty("user_id")]
	public int? UserIdentifier { get; set; }

	[JsonProperty("source")]
	public string Source { get; set; }
}
