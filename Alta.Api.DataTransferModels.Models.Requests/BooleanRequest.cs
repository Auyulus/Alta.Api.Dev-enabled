using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class BooleanRequest
{
	[JsonProperty("value")]
	public bool Value { get; set; }
}
