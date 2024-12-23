using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class Comment
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("userId")]
	public int User { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("comment")]
	public string Content { get; set; }

	[JsonProperty("hidden")]
	public bool IsHidden { get; set; }

	[JsonProperty("date")]
	public DateTime Date { get; set; }

	[JsonProperty("system")]
	public bool IsSystem { get; set; }
}
