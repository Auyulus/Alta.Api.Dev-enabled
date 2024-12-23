using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Form
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("completed")]
	public bool IsCompleted { get; set; }

	[JsonProperty("pages")]
	public List<Page> Pages { get; set; }

	[JsonProperty("start")]
	public DateTime Start { get; set; }

	[JsonProperty("end")]
	public DateTime End { get; set; }

	[JsonProperty("enabled")]
	public bool IsEnabled { get; set; }

	[JsonProperty("allowMultiple")]
	public bool AllowMultiple { get; set; }

	[JsonProperty("completionText")]
	public string CompletionText { get; set; }
}
