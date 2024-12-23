using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ClaimOculusItemsResponse
{
	[Obsolete]
	[JsonProperty("value")]
	public bool Value { get; set; }

	[JsonProperty("claimed_items")]
	public List<string> ClaimedItems { get; set; } = new List<string>();
}
