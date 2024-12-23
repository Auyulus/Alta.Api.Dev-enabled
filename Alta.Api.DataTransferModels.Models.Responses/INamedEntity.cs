namespace Alta.Api.DataTransferModels.Models.Responses;

public interface INamedEntity
{
	int Identifier { get; }

	string Name { get; }
}
