using Alta.Api.DataTransferModels.Models.Responses;
using MediatR;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class RegisterRequest : EmailAndUsernameRequest, IRequest<UserInfo>, IBaseRequest
{
	[JsonProperty("password_hash")]
	public string PasswordHash { get; set; }

	[JsonProperty("referral")]
	public string Referral { get; set; }

	[JsonProperty("oculus")]
	public AccountLinkData OculusAccountLink { get; set; }

	[JsonProperty("pico")]
	public AccountLinkData PicoAccountLink { get; set; }
}
