using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses.DTOs.Responses;

public class FriendRequestResult
{
	[JsonProperty("result")]
	public FriendRequestedType Result { get; set; }

	[JsonProperty("friendship")]
	public FriendshipInfo Friendship { get; set; }

	[JsonProperty("reverse_friendship")]
	public FriendshipInfo ReverseFriendship { get; set; }
}
