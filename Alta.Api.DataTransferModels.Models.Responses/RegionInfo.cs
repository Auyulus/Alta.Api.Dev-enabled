using System.Net;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class RegionInfo
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("display_name")]
	public string DisplayName { get; set; }

	[JsonProperty("country_code")]
	public string CountryCode { get; set; }

	[JsonProperty("ping_address")]
	public IPAddress PingAddress { get; set; }
}
