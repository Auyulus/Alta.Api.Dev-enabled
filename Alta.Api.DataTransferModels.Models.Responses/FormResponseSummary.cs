using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class FormResponseSummary
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("formId")]
	public int FormIdentifier { get; set; }

	[JsonProperty("userId")]
	public int UserIdentifier { get; set; }

	[JsonProperty("submitted")]
	public DateTime Submitted { get; set; }

	[JsonProperty("processed")]
	public DateTime Processed { get; set; }
}
