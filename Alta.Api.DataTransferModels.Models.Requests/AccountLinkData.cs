using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class AccountLinkData
{
	[JsonProperty("identifier")]
	public ulong Identifier { get; set; }

	[JsonProperty("user_proof")]
	public string UserProof { get; set; }

	[JsonProperty("region")]
	public Region Region { get; set; }
}
