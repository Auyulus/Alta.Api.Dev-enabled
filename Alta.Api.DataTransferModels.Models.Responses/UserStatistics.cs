using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class UserStatistics
{
	[JsonProperty("sign_up_time")]
	public DateTime SignupTime { get; set; }

	[JsonProperty("play_time")]
	public TimeSpan? PlayTime { get; set; }
}
