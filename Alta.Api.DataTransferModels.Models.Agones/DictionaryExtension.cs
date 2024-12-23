using System.Collections.Generic;

namespace Alta.Api.DataTransferModels.Models.Agones;

public static class DictionaryExtension
{
	public static T2 SafeGetValue<T, T2>(this IDictionary<T, T2> dictionary, T key, T2 defaultValue)
	{
		if (dictionary.TryGetValue(key, out var value))
		{
			return value;
		}
		return defaultValue;
	}
}
