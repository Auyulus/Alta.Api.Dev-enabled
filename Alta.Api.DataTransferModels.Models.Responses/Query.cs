using System.Collections.Generic;
using Alta.Api.DataTransferModels.Enums.Alta.WebApi.Models;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Query
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("default")]
	public string DefaultValue { get; set; }

	[JsonProperty("type")]
	public FormQueryType Type { get; set; }

	[JsonProperty("options")]
	public List<Option> Options { get; set; }

	[JsonProperty("maxLength")]
	public int MaxLength { get; set; } = 20;

	[JsonProperty("context")]
	public string Context { get; set; }

	[JsonProperty("required")]
	public bool IsRequired { get; set; }
}
