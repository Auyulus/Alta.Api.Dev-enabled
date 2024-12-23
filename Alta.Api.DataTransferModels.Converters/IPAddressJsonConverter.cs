using System;
using System.Net;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Converters;

public class IPAddressJsonConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return typeof(IPAddress).IsAssignableFrom(objectType);
	}

	public override void WriteJson([NotNull] JsonWriter writer, [NotNull] object value, JsonSerializer serializer)
	{
		writer.WriteValue(value.ToString());
	}

	public override object ReadJson([NotNull] JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		string text = (string)reader.Value;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		if (IPAddress.TryParse(text, out var address))
		{
			return address;
		}
		return reader.Value;
	}
}
