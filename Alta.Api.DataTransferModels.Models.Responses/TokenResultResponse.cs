using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class TokenResultResponse
{
	[JsonProperty("access_token")]
	public JwtSecurityToken AccessToken { get; set; }

	[JsonProperty("refresh_token")]
	public JwtSecurityToken RefreshToken { get; set; }

	[JsonProperty("identity_token")]
	public JwtSecurityToken IdentityToken { get; set; }

	public TokenResultResponse(JwtSecurityToken accessToken, JwtSecurityToken refreshToken, JwtSecurityToken identityToken)
	{
		AccessToken = accessToken;
		RefreshToken = refreshToken;
		IdentityToken = identityToken;
	}
}
