using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class SimpleTokenResultResponse
{
	[JsonProperty("token")]
	public JwtSecurityToken Token { get; set; }

	public SimpleTokenResultResponse(JwtSecurityToken token)
	{
		Token = token;
	}
}