using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using Alta.Api.DataTransferModels.Converters;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alta.Api.DataTransferModels.Extensions;

public static class WebRequestExtensions
{
	public static string SerializeToString([NotNull] this Stream contentStream)
	{
		return SerializeContentStream(contentStream);
	}

	[NotNull]
	public static string SerializeToString([NotNull] this HttpResponseHeaders headers)
	{
		return string.Join(Environment.NewLine, headers.Select((KeyValuePair<string, IEnumerable<string>> header) => header.Key + ": " + (header.Key.Equals("authorization", StringComparison.InvariantCultureIgnoreCase) ? "redacted" : string.Join(",", header.Value))));
	}

	public static string SerializeContentStream([NotNull] Stream contentStream)
	{
		MemoryStream memoryStream = new MemoryStream();
		if (contentStream.CanSeek)
		{
			contentStream.Seek(0L, SeekOrigin.Begin);
		}
		contentStream.CopyTo(memoryStream);
		if (contentStream.CanSeek)
		{
			contentStream.Seek(0L, SeekOrigin.Begin);
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return SerializeBody(memoryStream);
	}

	private static string SerializeBody([NotNull] Stream inputStream)
	{
		using StreamReader streamReader = new StreamReader(inputStream);
		string text = streamReader.ReadToEnd();
		if (text.Length <= 0)
		{
			return text;
		}
		try
		{
			text = JToken.Parse(text).ToString(Formatting.Indented, new SensitiveStringConverter());
		}
		catch
		{
		}
		return text;
	}
}
