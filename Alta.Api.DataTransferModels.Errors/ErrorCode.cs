namespace Alta.Api.DataTransferModels.Errors;

public enum ErrorCode
{
	None,
	InvalidPassword,
	ItemNotAvailableForPurchase,
	ItemAlreadyOwned,
	NotEnoughCurrency,
	UserBalanceUpdateFailed,
	ItemAttributionFailed,
	UnspecifiedError,
	FailedRetrievingTalemPackage,
	NoCouponAvailableForPackage,
	ProcessingPurchaseFailed,
	ObjectNotFound,
	InvalidBanTarget,
	InvalidFleetSpecified,
	NoPermissionsToRemoveBan,
	VerificationCodeGenerationFailed,
	InvalidVerificationToken,
	EmptyEmail,
	EmailAlreadyInUse,
	FailedSendingEmail,
	InvalidUser,
	UsernameAlreadyTaken,
	AccountAlreadyLinked,
	InvalidOculusCredentials,
	LinkingFailed,
	NoUniqueUsername,
	NoMatchingRegion,
	CouldNotAccessServer,
	NoAccountFound,
	ExpiredToken,
	InvalidRequestModel,
	UserNotPlayingOnServer,
	DataAlreadyExists,
	InvalidActionOnSelf,
	ActionAlreadyInProgress,
	InvalidRegion,
	CantGetPrivateGroup,
	CantCreateMoreServers,
	CantModifyGroupCreator,
	InvalidPermissionsToPerformAction,
	InvalidLoginCredentials,
	ActionPerformedRecently,
	ServerIsNotOnline,
	AlreadyHasStatus,
	InvalidServerSession,
	CannotStartServer,
	InvalidFormat,
	FailedCreatingTransaction,
	InvalidSubscription,
	InvalidCouponCode,
	ShopAdminError,
	IncorrectCurrency,
	ActionNotSupported,
	RetryActionLater,
	NotImplemented,
	MissingConnectionIdentifier,
	InvalidRedirect,
	SkuAlreadyExists,
	InvalidQueryValue,
	BadGateway
}