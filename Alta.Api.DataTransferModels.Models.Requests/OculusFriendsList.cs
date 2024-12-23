using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Requests;

public class OculusFriendsList
{
	[JsonProperty("oculus_friends")]
	public IEnumerable<ulong> OculusFriends { get; set; }
}
