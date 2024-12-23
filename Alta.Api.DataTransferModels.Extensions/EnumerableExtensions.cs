using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Alta.Api.DataTransferModels.Extensions;

public static class EnumerableExtensions
{
	public static bool ContainsAny<T>([NotNull] this ICollection<T> list, [NotNull] IEnumerable<T> otherList)
	{
		return otherList.Any(list.Contains);
	}

	public static void AddAll<T>(this ICollection<T> list, [NotNull] IEnumerable<T> itemsToAdd)
	{
		foreach (T item in itemsToAdd)
		{
			list.Add(item);
		}
	}

	public static void RemoveAll<T>(this ICollection<T> list, [NotNull] IEnumerable<T> itemsToRemove)
	{
		foreach (T item in itemsToRemove)
		{
			list.Remove(item);
		}
	}

	public static IEnumerable<T> AsEnumerable<T>(this T item)
	{
		yield return item;
	}

	[NotNull]
	public static List<T> AsList<T>(this T item)
	{
		return item.AsEnumerable().ToList();
	}

	[ItemNotNull]
	public static IEnumerable<IEnumerable<TSource>> Batch<TSource>([NotNull] this IEnumerable<TSource> source, int size)
	{
		TSource[] array = null;
		int num = 0;
		foreach (TSource item in source)
		{
			if (array == null)
			{
				array = new TSource[size];
			}
			array[num++] = item;
			if (num == size)
			{
				yield return array;
				array = null;
				num = 0;
			}
		}
		if (array != null && num > 0)
		{
			yield return array.Take(num).ToArray();
		}
	}
}
