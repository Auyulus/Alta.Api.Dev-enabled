using System.Collections.Generic;
using Alta.Api.DataTransferModels.Models.Responses;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class SetServersOnlinePlayersRequest
{
	[JsonProperty("online_players")]
	public IEnumerable<UserInfo> OnlinePlayers { get; set; }

	[JsonProperty("session")]
	public int Session { get; set; }
}
