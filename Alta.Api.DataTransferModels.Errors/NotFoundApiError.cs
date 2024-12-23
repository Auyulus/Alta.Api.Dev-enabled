namespace Alta.Api.DataTransferModels.Errors;

public class NotFoundApiError : ApiError
{
	public NotFoundApiError()
	{
		base.Message = "Not found";
		base.ErrorCode = ErrorCode.ObjectNotFound;
	}
}
