using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class EmailValidationRequest
{
	[JsonProperty("email")]
	public string Email { get; set; }
}
