using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace Alta.Api.DataTransferModels.Utility;

public class RetryHandler : HttpClientHandler
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	private readonly int maxRetryAmount;

	private readonly TimeSpan timeout;

	public static event Action<HttpRequestMessage> TimedOut;

	public RetryHandler(float timeOutInSeconds, int maxRetryAmount = 3)
	{
		this.maxRetryAmount = maxRetryAmount;
		timeout = TimeSpan.FromSeconds(timeOutInSeconds);
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		string uriString = request.RequestUri.ToString();
		Logger.Debug("{0}: {1}", request.Method.Method, uriString);
		try
		{
			HttpResponseMessage httpResponseMessage = await Task.Run(async delegate
			{
				int currentRetry = 0;
				while (currentRetry < maxRetryAmount)
				{
					using CancellationTokenSource cts = CreateTimeoutTokenSource(cancellationToken);
					currentRetry++;
					try
					{
						return await base.SendAsync(request, cts.Token);
					}
					catch (TaskCanceledException exception)
					{
						Logger.Warn(exception, "Sending API Request timed out ({0}: {1})", request.Method.Method, uriString);
					}
					catch (Exception exception2)
					{
						if (currentRetry >= maxRetryAmount)
						{
							throw;
						}
						Logger.Warn(exception2, "Sending API Request failed, retrying... ({0}: {1})", request.Method.Method, uriString);
					}
					if (currentRetry < maxRetryAmount)
					{
						double num = Math.Pow(2.0, currentRetry);
						Logger.Info($"Retrying web request sending in {num} seconds");
						await Task.Delay((int)(num * 1000.0));
					}
				}
				return (HttpResponseMessage)null;
			});
			if (httpResponseMessage != null)
			{
				return httpResponseMessage;
			}
		}
		catch (Exception ex)
		{
			Logger.Error(ex, "Failed sending web request to: {0}", request.RequestUri);
			throw new HttpRequestException("Failed sending request", ex);
		}
		RetryHandler.TimedOut?.Invoke(request);
		throw new TimeoutException();
	}

	private CancellationTokenSource CreateTimeoutTokenSource(CancellationToken cancellationToken)
	{
		CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		cancellationTokenSource.CancelAfter(timeout);
		return cancellationTokenSource;
	}
}
