using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests.DTOs.Requests;

public class FriendRequestResponse
{
	[JsonProperty("accepted")]
	public bool IsAccepted { get; set; }
}
