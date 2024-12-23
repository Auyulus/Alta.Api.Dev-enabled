using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class OculusFriendInfo : FriendshipInfo
{
	[JsonProperty("oculus_identifier")]
	public ulong OculusIdentifier { get; set; }
}
