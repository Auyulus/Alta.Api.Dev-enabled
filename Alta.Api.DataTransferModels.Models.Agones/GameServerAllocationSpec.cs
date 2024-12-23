using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class GameServerAllocationSpec
{
	public class RequiredSpec
	{
		[JsonProperty("matchLabels")]
		public Dictionary<string, string> MatchLabels { get; set; }
	}

	[Obsolete]
	[JsonProperty("required")]
	public RequiredSpec Required { get; set; }

	[JsonProperty("selectors")]
	public RequiredSpec[] Selectors { get; set; }

	[JsonProperty("scheduling")]
	public string Scheduling { get; set; }

	[JsonProperty("metadata")]
	public Metadata Metadata { get; set; }
}
