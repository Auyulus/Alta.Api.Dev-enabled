using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class FutureUserActionCreateRequest
{
	[JsonProperty("user_type")]
	public UserType UserType { get; set; }

	[JsonProperty("user_id")]
	public ulong UserIdentifier { get; set; }

	[JsonProperty("type")]
	public FutureUserActionType ActionType { get; set; }

	[JsonProperty("action_data")]
	public dynamic ActionData { get; set; }
}
