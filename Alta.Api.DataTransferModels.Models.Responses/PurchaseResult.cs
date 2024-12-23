using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class PurchaseResult
{
	[JsonProperty("result")]
	public PurchaseResultType Result { get; set; }

	[JsonProperty("transaction_id")]
	public int? TransactionIdentifier { get; set; }

	public PurchaseResult()
	{
	}

	public PurchaseResult(PurchaseResultType result)
	{
		Result = result;
	}
}
