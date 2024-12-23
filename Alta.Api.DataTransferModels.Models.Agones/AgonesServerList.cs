using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class AgonesServerList
{
	[JsonProperty("items")]
	public IEnumerable<AgonesGameServer> Items { get; set; }
}
