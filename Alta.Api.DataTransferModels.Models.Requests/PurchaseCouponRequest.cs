using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class PurchaseCouponRequest
{
	[JsonProperty("currency_package_id")]
	public int CurrencyPackageId { get; set; }

	[JsonProperty("quantity")]
	public int Quantity { get; set; } = 1;
}
