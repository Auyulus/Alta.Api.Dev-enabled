using System;

namespace Alta.Api.DataTransferModels.Enums;

[Flags]
public enum PermissionType
{
	Edit = 1,
	Respond = 2,
	ViewResponses = 4,
	ViewComments = 8,
	ViewHiddenComments = 0x10,
	Comment = 0x20,
	Resolve = 0x40,
	Unresolve = 0x80
}
