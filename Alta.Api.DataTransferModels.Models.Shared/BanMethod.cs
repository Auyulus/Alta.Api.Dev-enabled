using System;

namespace Alta.Api.DataTransferModels.Models.Shared;

[Flags]
public enum BanMethod
{
	UserId = 1,
	IpAddress = 2,
	DeviceId = 4
}
