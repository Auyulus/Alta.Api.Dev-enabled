namespace Alta.Api.DataTransferModels.Models.Responses;

public enum PurchaseResultType
{
	NotAvailable,
	NotEnoughShards,
	AlreadyOwned,
	FailedDeductingShards,
	FailedGivingItem,
	Success,
	PremiumOnlyItem,
	ShardsOnlyItem
}
