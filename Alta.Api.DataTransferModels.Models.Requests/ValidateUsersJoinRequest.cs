using System.Net;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ValidateUsersJoinRequest
{
	[JsonProperty("identity_token")]
	public string IdentityToken { get; set; }

	[JsonProperty("device_id")]
	public string DeviceIdentifier { get; set; }

	[JsonProperty("ip_address")]
	public IPAddress IpAddress { get; set; }

	[JsonProperty("server_id")]
	public int ServerIdentifier { get; set; }
}
