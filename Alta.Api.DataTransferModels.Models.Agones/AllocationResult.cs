using Alta.Api.DataTransferModels.Models.Responses;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class AllocationResult
{
	public bool IsAllocated { get; set; }

	public ConnectionInfo ConnectionInfo { get; set; }

	public AgonesAllocationFailureType FailureType { get; set; }

	public string GameServerName { get; set; }
}
