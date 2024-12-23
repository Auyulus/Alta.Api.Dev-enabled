using System;
using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class FleetInfo
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("status")]
	public GameServerStatus Status { get; set; }

	[JsonProperty("additional_buffer")]
	public int? AdditionalBuffer { get; set; }

	[JsonProperty("buffer_last_update_time")]
	public DateTime? BufferLastUpdateTime { get; set; }
}
