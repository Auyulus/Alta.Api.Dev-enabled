using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Alta.Api.DataTransferModels.Utility;

public static class JwtTokenHandler
{
	private static readonly JwtSecurityTokenHandler Handler = new JwtSecurityTokenHandler();

	public static string Write(this JwtSecurityToken token)
	{
		if (token.SigningCredentials == null)
		{
			Claim claim2 = token.Claims.FirstOrDefault((Claim claim) => claim.Type == "raw");
			if (claim2 != null)
			{
				return claim2.Value;
			}
			return token.RawData;
		}
		return Handler.WriteToken(token);
	}
}
