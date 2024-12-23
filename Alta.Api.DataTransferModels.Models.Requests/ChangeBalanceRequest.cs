using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ChangeBalanceRequest
{
	[JsonProperty("change")]
	public int Change { get; set; }
}
