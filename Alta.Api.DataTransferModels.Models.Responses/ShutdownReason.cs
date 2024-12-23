using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class ShutdownReason
{
	[JsonProperty("reason")]
	public string Reason { get; set; }

	[JsonProperty("is_expected")]
	public bool IsExpected { get; set; }

	public ShutdownReason(string reason, bool isExpected)
		: this(reason)
	{
		IsExpected = isExpected;
	}

	public ShutdownReason(string reason)
	{
		Reason = reason;
	}

	public ShutdownReason()
	{
	}

	public override string ToString()
	{
		return $"Reason: {Reason}, Is Expected: {IsExpected}";
	}
}
