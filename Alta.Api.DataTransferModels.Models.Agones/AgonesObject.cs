using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public abstract class AgonesObject
{
	[JsonProperty("apiVersion")]
	public string ApiVersion
	{
		get
		{
			return ApiGroup + "/" + Version;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public string Version { get; set; } = "v1";

	[JsonIgnore]
	public virtual string ApiGroup { get; set; } = "allocation.agones.dev";

	[JsonProperty("kind")]
	public virtual string Kind { get; set; }

	[JsonProperty("metadata")]
	public Metadata Metadata { get; set; } = new Metadata();

	[JsonProperty("status")]
	public Status Status { get; set; }
}
