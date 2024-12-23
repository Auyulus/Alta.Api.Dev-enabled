using System;
using System.Net;
using Alta.Api.DataTransferModels.Errors;

namespace Alta.Api.DataTransferModels.Exceptions;

public class ApiErrorException : Exception
{
	public ApiError ApiError { get; }

	public HttpStatusCode HttpCode { get; }

	public ApiErrorException(ApiError apiError, HttpStatusCode httpCode = HttpStatusCode.InternalServerError)
		: base(apiError.Message)
	{
		ApiError = apiError;
		HttpCode = httpCode;
	}

	public ApiErrorException(ErrorCode errorCode, string message, HttpStatusCode httpCode = HttpStatusCode.InternalServerError)
		: base(message)
	{
		ApiError = new ApiError(errorCode, message);
		HttpCode = httpCode;
	}
}
