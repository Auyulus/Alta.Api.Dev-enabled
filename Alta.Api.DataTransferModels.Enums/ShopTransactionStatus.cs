using System;

namespace Alta.Api.DataTransferModels.Enums;

public enum ShopTransactionStatus
{
	Started,
	Processing,
	ShardDeductionFailed,
	[Obsolete]
	ItemAttributionFailed,
	ItemAttributionFailedFree,
	ItemAttributionFailedRefunded,
	ItemAttributionFailedNotRefunded,
	CouponEmailFailedNotRefunded,
	ShardAttributionFailed,
	Successful,
	Refunded
}
