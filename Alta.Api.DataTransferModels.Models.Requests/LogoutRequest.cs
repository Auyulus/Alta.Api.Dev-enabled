using System.IdentityModel.Tokens.Jwt;
using Alta.Api.DataTransferModels.Utility;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LogoutRequest
{
	[JsonProperty("refresh_token")]
	public string RefreshToken { get; private set; }

	public LogoutRequest()
	{
	}

	public LogoutRequest(JwtSecurityToken refreshToken)
	{
		RefreshToken = refreshToken.Write();
	}
}
