using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class LoginViaLinkedAccountRequest : AccountRequestBase
{
	[JsonProperty("device_id")]
	public string DeviceIdentifier { get; set; }
}
