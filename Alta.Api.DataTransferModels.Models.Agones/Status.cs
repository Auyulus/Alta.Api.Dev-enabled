using System.Net;
using Alta.Api.DataTransferModels.Converters;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class Status
{
	public enum GameServerState
	{
		Creating,
		PortAllocation,
		Error,
		Starting,
		Scheduled,
		RequestReady,
		Ready,
		Allocated,
		UnAllocated,
		Shutdown,
		Unhealthy
	}

	[JsonProperty("state")]
	public GameServerState State { get; set; }

	[JsonProperty("gameServerName")]
	public string GameServerName { get; set; }

	[JsonProperty("address")]
	[JsonConverter(typeof(IPAddressJsonConverter))]
	public IPAddress Address { get; set; }

	[JsonProperty("ports")]
	public PortConfig[] Ports { get; set; }

	[JsonProperty("nodeName")]
	public string NodeName { get; set; }
}
