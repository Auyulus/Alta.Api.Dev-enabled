using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json;
using NLog;

namespace Alta.Api.DataTransferModels.Extensions;

public static class HttpClientExtensions
{
	public class JsonContent : StringContent
	{
		public JsonContent(object obj)
			: base(Convert(obj), Encoding.UTF8, "application/json")
		{
		}

		private static string Convert([CanBeNull] object obj)
		{
			if (obj == null)
			{
				logger.Warn("JsonContent with null object");
				return string.Empty;
			}
			string text = JsonConvert.SerializeObject(obj);
			logger.Trace("Converted data to json:");
			logger.Trace(text);
			return text;
		}
	}

	private static readonly Logger logger = LogManager.GetCurrentClassLogger();

	public static async Task<HttpResponseMessage> PostAsync<T>([NotNull] this HttpClient client, [NotNull] string uri)
	{
		LogApiRequest(uri);
		HttpResponseMessage response = await client.PostAsync(uri, null);
		await response.LogDebugResponse();
		return response;
	}

	public static async Task<HttpResponseMessage> PostJsonAsync<T>([NotNull] this HttpClient client, string uri, T content, [CanBeNull] Action<JsonContent> modifyContent = null)
	{
		JsonContent jsonContent = new JsonContent(content);
		modifyContent?.Invoke(jsonContent);
		LogApiRequest(uri, jsonContent);
		HttpResponseMessage response = await client.PostAsync(uri, jsonContent);
		await response.LogDebugResponse();
		return response;
	}

	private static async Task LogApiRequest(string uri, JsonContent content)
	{
		string text = await content.ReadAsStringAsync();
		logger.Debug("API call: " + uri + "\ncontent:" + text);
	}

	private static void LogApiRequest(string uri)
	{
		logger.Debug("API call: " + uri + "\n witn no content (expected).");
	}

	public static Task<HttpResponseMessage> PutJsonAsync<T>([NotNull] this HttpClient client, string uri, T content)
	{
		return client.PutAsync(uri, new JsonContent(content));
	}

	[NotNull]
	public static Task<HttpResponseMessage> PatchJsonAsync<T>(this HttpClient client, string uri, T content)
	{
		return client.PatchAsync(uri, new JsonContent(content));
	}

	[NotNull]
	public static Task<HttpResponseMessage> DeleteJsonAsync<T>(this HttpClient client, string uri, T content)
	{
		return client.DeleteAsync(uri, new JsonContent(content));
	}

	public static async Task<HttpResponseMessage> PatchAsync([NotNull] this HttpClient client, string requestUri, HttpContent content)
	{
		HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri)
		{
			Content = content
		};
		return await client.SendAsync(request);
	}

	public static async Task<HttpResponseMessage> DeleteAsync([NotNull] this HttpClient client, string requestUri, HttpContent content)
	{
		HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("DELETE"), requestUri)
		{
			Content = content
		};
		return await client.SendAsync(request);
	}
}
