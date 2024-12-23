namespace Alta.Api.DataTransferModels.Helpers;

public static class ShopHelper
{
	public const string ItemSetPrefix = "set_";

	public static bool IsItemSet(string itemSku)
	{
		return itemSku?.StartsWith("set_") ?? false;
	}

	public static string EnsureItemSetSku(string sku)
	{
		if (!IsItemSet(sku))
		{
			return "set_" + sku;
		}
		return sku;
	}
}
