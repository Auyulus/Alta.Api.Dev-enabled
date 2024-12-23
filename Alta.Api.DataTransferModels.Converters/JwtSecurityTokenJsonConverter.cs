using System;
using System.IdentityModel.Tokens.Jwt;
using Alta.Api.DataTransferModels.Utility;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Converters;

public class JwtSecurityTokenJsonConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(JwtSecurityToken);
	}

	public override void WriteJson([NotNull] JsonWriter writer, object value, JsonSerializer serializer)
	{
		writer.WriteValue((value as JwtSecurityToken).Write());
	}

	[NotNull]
	public override object ReadJson([NotNull] JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return JWTUtility.CreateFromString((string)reader.Value, includeRawData: true);
	}
}
