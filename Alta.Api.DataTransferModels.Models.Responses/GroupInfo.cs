using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class GroupInfo
{
	[JsonProperty("id")]
	public int Identifier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("member_count")]
	public int MemberCount { get; set; }

	[JsonProperty("created_at")]
	public DateTime CreatedAt { get; set; }

	[JsonProperty("type")]
	[JsonConverter(typeof(StringEnumConverter))]
	public GroupType GroupType { get; set; }

	[JsonProperty("tags")]
	public List<string> Tags { get; set; }

	public override string ToString()
	{
		return Identifier + " - " + Name;
	}
}
