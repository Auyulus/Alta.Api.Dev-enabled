using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ClientTokenConfig
{
	[JsonProperty("client_id")]
	public string ClientId { get; set; }

	[JsonProperty("client_secret")]
	public string ClientSecret { get; set; }

	[JsonProperty("scope")]
	public string Scope { get; set; }
}
