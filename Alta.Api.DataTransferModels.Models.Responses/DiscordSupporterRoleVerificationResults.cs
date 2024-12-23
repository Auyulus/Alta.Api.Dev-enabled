using System.Collections.Generic;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class DiscordSupporterRoleVerificationResults
{
	public List<UserInfo> GainedSupporters { get; }

	public List<UserInfo> RemovedSupporters { get; }

	public DiscordSupporterRoleVerificationResults()
	{
		GainedSupporters = new List<UserInfo>();
		RemovedSupporters = new List<UserInfo>();
	}
}
