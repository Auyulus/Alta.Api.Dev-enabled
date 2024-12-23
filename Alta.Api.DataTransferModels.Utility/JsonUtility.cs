using Alta.Api.DataTransferModels.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alta.Api.DataTransferModels.Utility;

public static class JsonUtility
{
	public static JsonConverter[] AllConverters = new JsonConverter[4]
	{
		new IPAddressJsonConverter(),
		new RegionEndpointJsonConverter(),
		new JwtSecurityTokenJsonConverter(),
		new StringEnumConverter()
	};

	public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
	{
		Converters = AllConverters,
		DateFormatHandling = DateFormatHandling.IsoDateFormat,
		NullValueHandling = NullValueHandling.Ignore,
		DateTimeZoneHandling = DateTimeZoneHandling.Utc
	};

	public static void SetupJsonSerializerSettings()
	{
		JsonConvert.DefaultSettings = () => Settings;
	}
}
