using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PublicUserInfoResponse : UserInfo
{
	[JsonProperty("statistics")]
	public UserStatistics Statistics { get; set; }

	[JsonProperty("is_supporter")]
	public bool IsSupporter { get; set; }
}
