using System;
using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GameServerWebsocketResponse
{
	[JsonProperty("type")]
	public GameServerWebsocketResponseType Type;

	[JsonProperty("timeStamp")]
	public DateTime TimeStamp;

	[JsonProperty("eventType")]
	public string EventType;

	[JsonProperty("data")]
	public object Data;

	[JsonProperty("commandId")]
	public uint? CommandId;

	[JsonProperty("serialized")]
	private string serialized;

	public GameServerWebsocketResponse(GameServerWebsocketResponseType type, string eventType, object data, uint? commandId = null)
	{
		Type = type;
		TimeStamp = DateTime.UtcNow;
		EventType = eventType;
		Data = data;
		CommandId = commandId;
		serialized = null;
	}
}
