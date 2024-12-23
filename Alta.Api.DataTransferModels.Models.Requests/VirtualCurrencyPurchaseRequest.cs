using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class VirtualCurrencyPurchaseRequest : PurchaseRequest
{
	[JsonProperty("currency_package_id")]
	public int VirtualCurrencyPackageIdentifier { get; set; }
}
