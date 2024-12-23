using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class Duration
{
	[JsonProperty("value")]
	public int Period { get; set; }

	[JsonProperty("type")]
	public DurationType Type { get; set; }

	public int Months => Type switch
	{
		DurationType.Day => 0, 
		DurationType.Year => Period * 12, 
		_ => Period, 
	};
}
