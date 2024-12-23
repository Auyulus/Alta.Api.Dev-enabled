using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class SingleTokenResponse
{
	[JsonProperty("token")]
	public JwtSecurityToken Token { get; set; }
}
