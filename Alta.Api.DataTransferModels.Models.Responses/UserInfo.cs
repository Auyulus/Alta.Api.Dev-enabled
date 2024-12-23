using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class UserInfo : INamedEntity
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	string INamedEntity.Name => Username;

	public UserInfo()
	{
	}

	public UserInfo(int identifier, string username)
	{
		Identifier = identifier;
		Username = username;
	}

	public override bool Equals(object obj)
	{
		if (obj is UserInfo userInfo)
		{
			return Identifier == userInfo.Identifier;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return 1186239758 + Identifier;
	}

	public override string ToString()
	{
		return $"({Username}:{Identifier})";
	}
}
