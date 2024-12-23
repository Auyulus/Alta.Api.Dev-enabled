using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Converters;

public class SensitiveStringConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(string);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		if (writer.Path.IndexOf("password", StringComparison.InvariantCultureIgnoreCase) == -1 && writer.Path.IndexOf("token", StringComparison.InvariantCultureIgnoreCase) == -1 && writer.Path.IndexOf("nonce", StringComparison.InvariantCultureIgnoreCase) == -1)
		{
			writer.WriteValue(value.ToString());
		}
		else
		{
			writer.WriteValue("*");
		}
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return (string)reader.Value;
	}
}
