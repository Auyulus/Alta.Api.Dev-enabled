using System.Collections.Generic;
using Alta.Api.DataTransferModels.Errors;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ValidationResultModel
{
	[JsonProperty("errors")]
	public List<ValidationError> Errors { get; set; }

	public ValidationResultModel()
	{
	}

	public ValidationResultModel(List<ValidationError> errors)
	{
		Errors = errors;
	}

	public override string ToString()
	{
		return string.Join("\n", Errors);
	}
}
