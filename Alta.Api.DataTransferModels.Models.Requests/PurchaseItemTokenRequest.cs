using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class PurchaseItemTokenRequest
{
	[JsonProperty("item_id")]
	public int ItemIdentifier { get; set; }

	[JsonProperty("oculus_credentials")]
	public AccountRequestBase OculusCredentials { get; set; }
}
