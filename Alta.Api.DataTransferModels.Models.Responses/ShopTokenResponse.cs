using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopTokenResponse
{
	[JsonProperty("transaction_id")]
	public int TransactionIdentifier { get; set; }

	[JsonProperty("token")]
	public string Token { get; set; }

	[JsonProperty("shop_url")]
	public string ShopUrl => "https://secure.xsolla.com/paystation3/?access_token=" + Token;

	public ShopTokenResponse(string token, int transactionIdentifier)
	{
		TransactionIdentifier = transactionIdentifier;
		Token = token;
	}
}
