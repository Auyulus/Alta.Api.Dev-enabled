using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class JoinedGroupInfo
{
	[JsonProperty("group")]
	public GroupInfoDetailed Group { get; set; }

	[JsonProperty("member")]
	public GroupMemberInfo MemberInfo { get; set; }
}
