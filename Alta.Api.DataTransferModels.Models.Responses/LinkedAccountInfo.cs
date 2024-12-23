using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class LinkedAccountInfo
{
	[JsonProperty("id")]
	public ulong Identifier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	public LinkedAccountInfo(string name, ulong identifier)
	{
		Identifier = identifier;
		Name = name;
	}

	public LinkedAccountInfo()
	{
	}
}
