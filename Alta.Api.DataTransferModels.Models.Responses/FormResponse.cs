using System.Collections.Generic;
using Alta.Api.DataTransferModels.Converters;
using Alta.Api.DataTransferModels.Enums;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class FormResponse : FormResponseSummary
{
	[JsonProperty("pageResponses")]
	public List<PageResponse> PageResponses { get; set; }

	[JsonProperty("processingComment")]
	public string ProcessingComment { get; set; }

	[JsonProperty("comments")]
	public List<Comment> Comments { get; set; }

	[JsonProperty("permissions")]
	[JsonConverter(typeof(ForceDefaultConverter))]
	public PermissionType Permissions { get; set; }
}
