namespace Alta.Api.DataTransferModels.Models.Responses;

public enum ServerJoinFailResult
{
	Nothing,
	NotAllowedToSeeServer,
	NotAllowedToJoinServer,
	NotOnline,
	NotLaunched,
	CouldntAccessCluster,
	WebRequestFailed,
	CouldntAllocate,
	LockedServer,
	WrongClientGameVersion,
	BannedUser,
	CouldntVerifyUser,
	PlayerLimitReached,
	CouldntAllocateWithMessage
}
