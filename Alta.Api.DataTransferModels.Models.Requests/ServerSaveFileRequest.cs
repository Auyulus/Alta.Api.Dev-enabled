using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class ServerSaveFileRequest
{
	[JsonProperty("file_paths")]
	public IEnumerable<string> FilePaths { get; set; }
}
