using System.Net;
using Alta.Api.DataTransferModels.Models.Shared;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LaunchLocalServerRequest
{
	[JsonProperty("local_address")]
	public IPAddress LocalAddress { get; set; }

	[JsonProperty("address")]
	public IPAddress Address { get; set; }

	[JsonProperty("game_port")]
	public int GamePort { get; set; }

	[JsonProperty("logging_port")]
	public int? LoggingPort { get; set; }

	[JsonProperty("console_port")]
	public int? ConsolePort { get; set; }

	[JsonProperty("websocket_port")]
	public int? WebSocketPort { get; set; }

	[JsonProperty("webserver_port")]
	public int? WebServerPort { get; set; }

	[JsonProperty("version")]
	public GameVersion GameVersion { get; set; }
}
