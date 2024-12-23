using System.Net;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ConnectionInfo
{
	[JsonProperty("server_id")]
	public int ServerId { get; set; }

	[JsonProperty("address")]
	public IPAddress Address { get; set; } = IPAddress.Loopback;

	[JsonProperty("local_address")]
	public IPAddress LocalAddress { get; set; } = IPAddress.Loopback;

	[JsonProperty("pod_name")]
	public string PodName { get; set; }

	[JsonProperty("game_port")]
	public int GamePort { get; set; } = 1757;

	[JsonProperty("console_port")]
	public int? ConsolePort { get; set; }

	[JsonProperty("logging_port")]
	public int? LoggingPort { get; set; }

	[JsonProperty("websocket_port")]
	public int? WebSocketPort { get; set; }

	[JsonProperty("webserver_port")]
	public int? WebServerPort { get; set; }
}
