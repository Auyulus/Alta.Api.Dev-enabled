using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class UserInfoWithPermissions : UserInfo
{
	[JsonProperty("policies")]
	public HashSet<string> Policies { get; private set; }

	[JsonProperty("verified")]
	public bool IsVerified { get; private set; }

	public UserInfoWithPermissions(int identifier, string username, bool isVerified, IEnumerable<string> policies)
		: base(identifier, username)
	{
		Policies = new HashSet<string>(policies);
		IsVerified = isVerified;
	}

	public void SetVerified()
	{
		IsVerified = true;
	}

	public static UserInfoWithPermissions FromToken(JwtSecurityToken token)
	{
		string value = token.Claims.First((Claim claim) => claim.Type == "UserId").Value;
		string value2 = token.Claims.First((Claim claim) => claim.Type == "Username").Value;
		bool isVerified = token.Claims.Any((Claim claim) => claim.Type == "is_verified");
		IEnumerable<string> source = from claim in token.Claims
			where claim.Type == "Policy"
			select claim.Value;
		return new UserInfoWithPermissions(policies: source.SelectMany((string policy) => policy.Split(',')), identifier: int.Parse(value), username: value2, isVerified: isVerified);
	}
}
