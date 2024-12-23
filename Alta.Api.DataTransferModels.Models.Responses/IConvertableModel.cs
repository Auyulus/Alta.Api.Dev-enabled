namespace Alta.Api.DataTransferModels.Models.Responses;

public interface IConvertableModel<TModel>
{
	TModel Convert();
}
