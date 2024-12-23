using System.Runtime.Serialization;

namespace Alta.Api.DataTransferModels.Models.Shared;

public enum DurationType
{
	[EnumMember(Value = "day")]
	Day,
	[EnumMember(Value = "month")]
	Month,
	[EnumMember(Value = "year")]
	Year
}
