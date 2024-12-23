using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Option
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("value")]
	public string Value { get; set; }

	[JsonProperty("image")]
	public string Image { get; set; }

	public Option(int id, string value)
	{
		Id = id;
		Value = value;
	}
}
