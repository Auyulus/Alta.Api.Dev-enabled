using System;
using System.Collections.Generic;
using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GameServerInfo : GameServerInfoMinimal
{
	public static readonly HashSet<int> PublicServers = new HashSet<int> { 882523785, 721921036, 1415054889, 921921035, 1681327828, 1384812879 };

	public const string DefaultFleetName = "att-release";

	private static readonly Dictionary<int, string> FleetMapping = new Dictionary<int, string>
	{
		[1] = "att-release",
		[2] = "att-quest"
	};

	[JsonProperty("id")]
	public new int Identifier { get; set; }

	[JsonProperty("name")]
	public new string Name { get; set; }

	[JsonProperty("online_players")]
	public IEnumerable<UserInfo> OnlinePlayers { get; set; }

	[JsonProperty("server_status")]
	[JsonConverter(typeof(StringEnumConverter))]
	public GameServerStatus ServerStatus { get; set; }

	[JsonProperty("final_status")]
	public GameServerStatus FinalStatus { get; set; }

	[JsonProperty("scene_index")]
	public int SceneIndex { get; set; }

	[JsonProperty("target")]
	public int Target { get; set; }

	[JsonProperty("region")]
	public string LaunchRegion { get; set; }

	[JsonProperty("online_ping")]
	public DateTime? LastOnlinePing { get; set; }

	[JsonProperty("last_online")]
	public DateTime? LastOnline { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("playability")]
	public float Playability { get; set; }

	[JsonProperty("version")]
	public string LastStartedVersion { get; set; }

	[JsonProperty("group_id")]
	public int? GroupIdentifier { get; set; }

	[JsonProperty("owner_type")]
	public ServerOwnerType OwnerType { get; set; }

	[JsonProperty("owner_id")]
	public int OwnerIdentifier { get; set; }

	[JsonProperty("type")]
	public ServerType ServerType { get; set; }

	[JsonProperty("fleet")]
	public string FleetName { get; set; }

	[JsonProperty("up_time")]
	public TimeSpan Uptime { get; set; }

	[JsonProperty("join_type")]
	public ServerJoinType JoinType { get; set; }

	[JsonProperty("player_count")]
	public int CurrentPlayerCount { get; set; }

	[JsonProperty("player_limit")]
	public int? PlayerLimit { get; set; }

	[JsonProperty("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("transport_system")]
	public int? TransportSystem { get; set; }

	public static GameServerInfo OfflineServer { get; } = new GameServerInfo
	{
		Name = "Offline Server",
		Identifier = -1
	};

	public static GameServerInfo LocalServer { get; } = new GameServerInfo
	{
		Name = "Local Server",
		Identifier = -1
	};

	public static string GetFleetName(int target)
	{
		if (FleetMapping.TryGetValue(target, out var value))
		{
			return value;
		}
		return "att-release";
	}

	public override string ToString()
	{
		return $"{Identifier} - {Name}\nTransport: {TransportSystem}\nStatus: {ServerStatus}\nFinal Status: {FinalStatus}\nScene: {SceneIndex}\nTarget: {Target}\nRegion: {LaunchRegion}\nDescription: {Description}\nPlayability: {Playability}\nVersion: {LastStartedVersion}\nGroup: {GroupIdentifier}\nOwner Type: {OwnerType}\nOwner ID: {OwnerIdentifier}\nType: {ServerType}\nFleet: {FleetName}\nJoin Type: {JoinType}";
	}
}
