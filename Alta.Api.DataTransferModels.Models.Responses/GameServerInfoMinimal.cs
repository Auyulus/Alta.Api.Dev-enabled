using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GameServerInfoMinimal : INamedEntity
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}
