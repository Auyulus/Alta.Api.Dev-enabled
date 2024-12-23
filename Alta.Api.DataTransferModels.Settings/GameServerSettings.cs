namespace Alta.Api.DataTransferModels.Settings;

public static class GameServerSettings
{
	public const int OnlinePingTime = 30;

	public static int TimeToAppearOnlineSinceLastPing = 40;

	public const int DefaultPort = 1757;

	public const int IdealPlayerCount = 12;

	public const float AbovePenalty = 2f;

	public const float BelowPenalty = 1f;

	public const float MaxPlayability = 36f;

	public const bool IsRankingZeroLowest = true;
}
