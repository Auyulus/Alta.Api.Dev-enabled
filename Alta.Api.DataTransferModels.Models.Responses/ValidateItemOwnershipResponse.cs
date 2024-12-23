using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ValidateItemOwnershipResponse
{
	[JsonProperty("is_valid_list")]
	public bool IsValidList { get; set; }
}
