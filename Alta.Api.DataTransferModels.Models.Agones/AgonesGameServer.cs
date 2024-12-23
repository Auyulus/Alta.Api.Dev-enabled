using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class AgonesGameServer : AgonesObject
{
	public override string ApiGroup { get; set; } = "agones.dev";

	public override string Kind { get; set; } = "GameServer";

	[JsonProperty("spec")]
	public GameServerSpec Spec { get; set; }
}
