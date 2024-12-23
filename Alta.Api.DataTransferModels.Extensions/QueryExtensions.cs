using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using JetBrains.Annotations;

namespace Alta.Api.DataTransferModels.Extensions;

public static class QueryExtensions
{
	[NotNull]
	public static string ToQueryString([NotNull] this NameValueCollection nvc)
	{
		IEnumerable<string> values = from key in nvc.AllKeys
			from value in nvc.GetValues(key)
			select $"{WebUtility.UrlEncode(key)}={WebUtility.UrlEncode(value)}";
		return string.Join("&", values);
	}
}
