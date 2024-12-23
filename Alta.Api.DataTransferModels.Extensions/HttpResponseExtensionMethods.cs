using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Alta.Api.DataTransferModels.Errors;
using Alta.Api.DataTransferModels.Exceptions;
using Newtonsoft.Json;
using NLog;

namespace Alta.Api.DataTransferModels.Extensions;

public static class HttpResponseExtensionMethods
{
	private const string RequestIdHeader = "X-Request-Id";

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public static async Task<T> HandleResponse<T>(this HttpResponseMessage response)
	{
		if (response.IsSuccessStatusCode)
		{
			return await response.Content.ReadAsJsonAsync<T>();
		}
		if (response.StatusCode == HttpStatusCode.BadRequest)
		{
			throw await CreateApiErrorExceptionAsync(response);
		}
		throw await HandleForbiddenOrOtherHttpStatus(response);
	}

	public static async Task LogErrorResponse(this HttpResponseMessage response)
	{
		string headersString = response.Headers.SerializeToString();
		string text = await response.Content.ReadAsStringAsync();
		response.Headers.TryGetValues("X-Request-Id", out var values);
		Logger.Error("Error Response for: {0} - {1} Headers: {2} Body: {3} RequestId: {4}", response.RequestMessage.Method.Method, response.RequestMessage.RequestUri.ToString(), headersString, text, values?.FirstOrDefault());
	}

	public static async Task LogDebugResponse(this HttpResponseMessage response)
	{
		string headersString = response.Headers.SerializeToString();
		string text = await response.Content.ReadAsStringAsync();
		response.Headers.TryGetValues("X-Request-Id", out var values);
		Logger.Debug("API Response for: {0} - {1}\nHeaders:\n{2}\n\nBody:\n{3}\n\nRequestId:\n{4}", response.RequestMessage.Method.Method, response.RequestMessage.RequestUri.ToString(), headersString, text, values?.FirstOrDefault());
	}

	public static async Task<Exception> HandleForbiddenOrOtherHttpStatus(HttpResponseMessage response)
	{
		Logger.Warn("Response Status: {0}", response.StatusCode);
		await response.LogErrorResponse();
		if (response.StatusCode == HttpStatusCode.Forbidden)
		{
			return new ForbiddenException("This user doesnt have access to this resource");
		}
		return new HttpException(response.StatusCode)
		{
			Response = response
		};
	}

	private static async Task<ApiErrorException> CreateApiErrorExceptionAsync(HttpResponseMessage response)
	{
		string contentString = await response.Content.ReadAsStringAsync();
		try
		{
			ApiError apiError = await Task.Run(() => JsonConvert.DeserializeObject<ApiError>(contentString));
			await response.Content.ReadAsStringAsync();
			response.Headers.TryGetValues("X-Request-Id", out var values);
			Logger.Warn("Response Status: {0} and Error: {1}, Request Id: {RequestId}", response.StatusCode, apiError?.Message, values.FirstOrDefault());
			return new ApiErrorException(apiError);
		}
		catch (Exception)
		{
			Logger.Warn("Response Status: {0} and Failed reading error as APIError class, raw data: {1}", response.StatusCode, contentString);
		}
		return new ApiErrorException(new ApiError(ErrorCode.UnspecifiedError, contentString));
	}
}
