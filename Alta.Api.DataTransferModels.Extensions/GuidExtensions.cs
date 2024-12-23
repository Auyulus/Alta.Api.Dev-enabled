using System;

namespace Alta.Api.DataTransferModels.Extensions;

public static class GuidExtensions
{
	public static string ToShortString(this Guid guid)
	{
		return guid.ToString("N");
	}

	public static string ToBase64String(this Guid guid)
	{
		return Convert.ToBase64String(guid.ToByteArray());
	}

	public static string NewBase64String()
	{
		return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
	}
}
