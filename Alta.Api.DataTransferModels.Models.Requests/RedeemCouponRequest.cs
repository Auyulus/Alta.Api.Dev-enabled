using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class RedeemCouponRequest
{
	[JsonProperty("coupon")]
	public string Coupon { get; set; }
}
