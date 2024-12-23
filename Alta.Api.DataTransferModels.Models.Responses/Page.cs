using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Page
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("queries")]
	public List<Query> Queries { get; set; }

	[JsonProperty("transitions")]
	public List<Transitions> Transitions { get; set; }
}
