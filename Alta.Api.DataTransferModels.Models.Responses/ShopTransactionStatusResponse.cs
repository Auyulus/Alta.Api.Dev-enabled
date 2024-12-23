using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopTransactionStatusResponse
{
	[JsonProperty("status")]
	public ShopTransactionStatus Status { get; set; }
}
