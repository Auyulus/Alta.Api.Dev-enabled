using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Errors;

public class ValidationError
{
	[JsonProperty("field")]
	public string Field { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }

	public ValidationError(string field, string message)
	{
		Field = ((field != string.Empty) ? field : null);
		Message = message;
	}

	public ValidationError()
	{
	}

	public override string ToString()
	{
		return "Field: " + Field + " - " + Message;
	}
}
