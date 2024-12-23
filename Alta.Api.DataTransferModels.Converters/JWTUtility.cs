using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

namespace Alta.Api.DataTransferModels.Converters;

public static class JWTUtility
{
	[NotNull]
	public static JwtSecurityToken CreateFromString([NotNull] string rawData, bool includeRawData = false)
	{
		string text = rawData.Split('.')[1];
		text = text.PadRight(4 * ((text.Length + 3) / 4), '=');
		byte[] bytes = Convert.FromBase64String(text);
		JObject jObject = JObject.Parse(Encoding.UTF8.GetString(bytes));
		List<Claim> list = new List<Claim>();
		foreach (KeyValuePair<string, JToken> item in jObject)
		{
			if (item.Value.HasValues)
			{
				foreach (JToken item2 in item.Value.Values())
				{
					list.Add(new Claim(item.Key, item2.Value<string>()));
				}
			}
			else
			{
				list.Add(new Claim(item.Key, item.Value.Value<string>()));
			}
		}
		if (includeRawData)
		{
			list.Add(new Claim("raw", rawData));
		}
		return new JwtSecurityToken(null, null, list);
	}
}
