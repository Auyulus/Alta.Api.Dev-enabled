using System;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class RecentPlayerInteractionInfo
{
	public DateTime InteractionTime { get; set; }

	public RecentPlayerInteractionType Type { get; set; }

	public UserInfo UserInfo { get; set; }

	public GameServerInfoMinimal Server { get; set; }
}
