using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ServerJoinResult
{
	[JsonProperty("server_id")]
	public int ServerIdentifier { get; set; }

	[JsonProperty("allowed")]
	public bool IsAllowed { get; set; }

	[JsonProperty("was_rejection")]
	public bool WasRejected { get; set; }

	[JsonProperty("cold_start")]
	public bool IsColdStart { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }

	[JsonProperty("fail_reason")]
	public ServerJoinFailResult FailReason { get; set; }

	[JsonProperty("connection")]
	public ConnectionInfo ConnectionInfo { get; set; }

	[JsonProperty("token")]
	public JwtSecurityToken Token { get; set; }

	public void SetToFailState(string failMessage, ServerJoinFailResult failReason)
	{
		Message = failMessage;
		WasRejected = true;
		FailReason = failReason;
	}
}
