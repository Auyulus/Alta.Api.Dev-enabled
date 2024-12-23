using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class RecentPlayerInteractionRequest
{
	[JsonProperty("other_user")]
	public UserInfo OtherUser { get; set; }

	[JsonProperty("type")]
	public RecentPlayerInteractionType Type { get; set; }
}
