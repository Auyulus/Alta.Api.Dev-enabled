using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class CreatePresetRequest
{
	[JsonProperty("bytes_size")]
	public int ByteSize { get; set; }

	[JsonProperty("data")]
	public uint[] Data { get; set; }

	[JsonProperty("preset_id")]
	public int PresetId { get; set; }
}
