using Alta.Api.DataTransferModels.Models.Responses;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Errors;

public class ApiError
{
	[JsonProperty("message")]
	public string Message { get; set; }

	[JsonProperty("error_code")]
	public ErrorCode ErrorCode { get; set; }

	[JsonProperty("request_model_errors")]
	public ValidationResultModel RequestModelErrors { get; set; }

	[JsonProperty("context")]
	public object Context { get; set; }

	public ApiError(ErrorCode errorCode, string message)
	{
		ErrorCode = errorCode;
		Message = message;
	}

	public ApiError(ErrorCode errorCode, string message, object context)
		: this(errorCode, message)
	{
		Context = context;
	}

	public ApiError(string message)
	{
		Message = message;
	}

	public ApiError()
	{
	}

	public override string ToString()
	{
		return "Message: " + Message + ((RequestModelErrors != null) ? ("Request Errors: " + RequestModelErrors) : "");
	}

	[NotNull]
	public static ApiError MakeForModelValidationError(ValidationResultModel validationResult)
	{
		return new ApiError(ErrorCode.InvalidRequestModel, "Bad API Request")
		{
			RequestModelErrors = validationResult
		};
	}

	[NotNull]
	public static ApiError Verbose(ErrorCode errorCode, string verboseError)
	{
		return new ApiError
		{
			ErrorCode = errorCode,
			Message = verboseError
		};
	}
}
