using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class IdentityTokenValidationRequest
{
	[JsonProperty("identity_token")]
	public string IdentityToken { get; private set; }

	public IdentityTokenValidationRequest(string identityToken)
	{
		IdentityToken = identityToken;
	}

	public IdentityTokenValidationRequest()
	{
	}
}
