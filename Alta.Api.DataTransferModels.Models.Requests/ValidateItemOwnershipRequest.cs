using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ValidateItemOwnershipRequest
{
	[Obsolete]
	[JsonProperty("items")]
	public IEnumerable<uint> Items { get; set; }

	[JsonProperty("item_skus")]
	public IEnumerable<string> ItemSKUs { get; set; }

	[JsonProperty("user_id")]
	public int UserIdentifer { get; set; }
}
