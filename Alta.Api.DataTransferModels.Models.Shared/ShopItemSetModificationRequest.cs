using System.Collections.Generic;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class ShopItemSetModificationRequest : ShopItemModificationRequest
{
	public List<ShopItemDetailed> SetItems { get; set; }
}
