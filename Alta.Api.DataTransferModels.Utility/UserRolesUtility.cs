using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Alta.Api.DataTransferModels.Converters;
using Alta.Api.DataTransferModels.Models.Shared;

namespace Alta.Api.DataTransferModels.Utility;

public static class UserRolesUtility
{
	public static UserRoles GetRolesFromIdentityToken(string identityToken)
	{
		return GetRolesFromIdentityToken(JWTUtility.CreateFromString(identityToken));
	}

	public static UserRoles GetRolesFromIdentityToken(JwtSecurityToken identityToken)
	{
		return new UserRoles
		{
			IsDeveloper = identityToken.Claims.Any((Claim claim) => claim.Type == "Policy" && claim.Value == "dev"),
			IsMember = identityToken.Claims.Any((Claim claim) => claim.Type == "Policy" && claim.Value == "supporter"),
			IsModerator = identityToken.Claims.Any((Claim claim) => claim.Type == "Policy" && claim.Value == "mod")
		};
	}
}
