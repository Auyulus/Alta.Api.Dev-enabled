namespace Alta.Api.DataTransferModels.Models.Responses;

public static class GroupTypeExtensions
{
	public static ServerJoinType ConvertToServerJoinType(this GroupType groupType)
	{
		return groupType switch
		{
			GroupType.Open => ServerJoinType.OpenGroup, 
			GroupType.Public => ServerJoinType.PublicGroup, 
			_ => ServerJoinType.GroupMember, 
		};
	}
}
