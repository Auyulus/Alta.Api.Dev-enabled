using System.Runtime.Serialization;

namespace Alta.Api.DataTransferModels.Models.Shared;

public enum UserSubscriptionInfoStatus
{
	[EnumMember(Value = "active")]
	Active,
	[EnumMember(Value = "canceled")]
	Cancelled,
	[EnumMember(Value = "non_renewing")]
	NonRenewing
}
