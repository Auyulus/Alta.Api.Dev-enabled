using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;

namespace Alta.Api.DataTransferModels.Extensions;

public static class HttpContentExtensions
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
	{
		string contentString = await content.ReadAsStringAsync();
		return await Task.Run(delegate
		{
			try
			{
				return JsonConvert.DeserializeObject<T>(contentString);
			}
			catch (Exception exception)
			{
				Logger.Error(exception, "Failed serializing string into object of type: {0} string: {1}", typeof(T).FullName, contentString);
				throw;
			}
		});
	}
}
