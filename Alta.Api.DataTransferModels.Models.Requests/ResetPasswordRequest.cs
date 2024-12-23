using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ResetPasswordRequest
{
	[JsonProperty("reset_token")]
	public string ResetToken { get; set; }

	[JsonProperty("new_password_hash")]
	public string NewPasswordHash { get; set; }
}
