using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class GameServerAllocation : AgonesObject
{
	public override string Kind { get; set; } = "GameServerAllocation";

	[JsonProperty("spec")]
	public GameServerAllocationSpec Spec { get; set; }
}
