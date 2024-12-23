using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class AccountRequestBase
{
	[JsonProperty("account_id")]
	public ulong Identifier { get; set; }

	[JsonProperty("link_token")]
	public string LinkToken { get; set; }

	[JsonProperty("region")]
	public Region Region { get; set; }
}
