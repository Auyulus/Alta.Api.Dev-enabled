namespace Alta.Api.DataTransferModels.Models.Shared;

public class UserRoles
{
	public bool IsMember { get; set; }

	public bool IsDeveloper
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public bool IsModerator { get; set; }
}
