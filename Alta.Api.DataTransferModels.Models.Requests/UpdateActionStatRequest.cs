using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class UpdateActionStatRequest
{
	[Obsolete]
	[JsonProperty("hash")]
	public uint StatHash { get; set; }

	[Obsolete]
	[JsonProperty("new_progress")]
	public float NewProgress { get; set; }

	[JsonProperty("stats")]
	public List<StatProgress> ActionStats { get; set; }
}
