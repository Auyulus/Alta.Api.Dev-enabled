using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class Metadata
{
	[JsonProperty("namespace")]
	public string Namespace { get; set; } = "default";

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("generateName")]
	public string GenerateName { get; set; }

	[JsonProperty("resourceVersion")]
	public string ResourceVersion { get; set; }

	[JsonProperty("creationTimestamp")]
	public DateTime? CreationTime { get; set; }

	[JsonProperty("labels")]
	public Dictionary<string, string> Labels { get; set; }

	[JsonProperty("annotations")]
	public Dictionary<string, string> Annotations { get; set; }
}
