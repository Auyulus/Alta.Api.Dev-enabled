using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class UserPresetDataInfo
{
	[JsonProperty("user_id")]
	public int UserId { get; set; }

	[JsonProperty("preset_id")]
	public int PresetId { get; set; }

	[JsonProperty("bytes_size")]
	public int ByteSize { get; set; }

	[JsonProperty("data")]
	public uint[] Data { get; set; }

	[JsonProperty("timestamp")]
	public DateTime CreatedAt { get; set; }
}
