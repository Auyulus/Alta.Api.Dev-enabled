namespace Alta.Api.DataTransferModels.Models.Agones;

public enum AgonesAllocationFailureType
{
	Nothing = 0,
	CouldntAccessCluster = 5,
	WebRequestFailed = 6,
	CouldntAllocate = 7,
	LockedServer = 8
}
