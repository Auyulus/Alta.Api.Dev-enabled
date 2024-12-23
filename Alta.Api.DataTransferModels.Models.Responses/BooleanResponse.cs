using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class BooleanResponse
{
	[JsonProperty("value")]
	public bool Value { get; private set; }

	public BooleanResponse(bool value)
	{
		Value = value;
	}
}
