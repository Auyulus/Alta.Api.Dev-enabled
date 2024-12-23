using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ChangeUsernameRequest
{
	[JsonProperty("new_username")]
	public string NewUsername { get; private set; }

	[JsonProperty("password_hash")]
	public string PasswordHash { get; private set; }

	public ChangeUsernameRequest(string newUsername, string passwordHash)
	{
		NewUsername = newUsername;
		PasswordHash = passwordHash;
	}

	public ChangeUsernameRequest()
	{
	}
}
