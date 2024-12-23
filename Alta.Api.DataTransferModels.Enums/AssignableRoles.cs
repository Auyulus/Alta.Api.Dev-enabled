using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alta.Api.DataTransferModels.Enums;

public enum AssignableRoles
{
	[JsonConverter(typeof(StringEnumConverter))]
	PreAlphaPlayer
}
