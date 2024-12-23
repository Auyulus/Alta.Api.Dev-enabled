using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class PurchaseRequest
{
	[JsonProperty("payment_method_id")]
	public int PaymentMethodIdentifier { get; set; }
}
