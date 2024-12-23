using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class CouponRedeemedResponse
{
	[JsonProperty("coupon_code")]
	public string CouponCode { get; set; }

	[JsonProperty("virtual_currency_amount")]
	public int VirtualCurrencyAmount { get; set; }

	[JsonProperty("virtual_items")]
	public object[] VirtualItems { get; set; }
}
