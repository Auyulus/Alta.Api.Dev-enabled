using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GiftRewardComment
{
	[JsonProperty("comment")]
	public string Comment { get; set; }
}
