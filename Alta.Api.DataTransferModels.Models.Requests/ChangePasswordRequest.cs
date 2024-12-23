using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ChangePasswordRequest
{
	[JsonProperty("old_password_hash")]
	public string OldPasswordHash { get; private set; }

	[JsonProperty("new_password_hash")]
	public string NewPasswordHash { get; private set; }

	public ChangePasswordRequest(string oldPasswordHash, string newPasswordHash)
	{
		OldPasswordHash = oldPasswordHash;
		NewPasswordHash = newPasswordHash;
	}

	public ChangePasswordRequest()
	{
	}
}
