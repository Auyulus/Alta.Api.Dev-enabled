using System.Runtime.Serialization;

namespace Alta.Api.DataTransferModels.Models.Requests;

public enum VoiceChatTokenRequestType
{
	[EnumMember(Value = "login")]
	Login,
	[EnumMember(Value = "join")]
	JoinChannel
}
