namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShopPageConfigurationWithBanner : ShopPageConfiguration
{
	public string Image { get; set; }

	public static ShopPageConfigurationWithBanner Create(ShopPageConfiguration shop, GameHomeConfiguration gameHome)
	{
		ShopPageConfigurationWithBanner shopPageConfigurationWithBanner = new ShopPageConfigurationWithBanner();
		shopPageConfigurationWithBanner.PrimaryItems = shop.PrimaryItems;
		shopPageConfigurationWithBanner.SecondaryItems = shop.SecondaryItems;
		HomeElement[] elements = gameHome.Elements;
		foreach (HomeElement homeElement in elements)
		{
			if (homeElement.Pages != null && homeElement.Pages.Length != 0)
			{
				shopPageConfigurationWithBanner.Image = homeElement.Pages[0].Image;
				break;
			}
		}
		return shopPageConfigurationWithBanner;
	}
}
