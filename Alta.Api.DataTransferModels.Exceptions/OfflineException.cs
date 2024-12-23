using System;
using System.Diagnostics;

namespace Alta.Api.DataTransferModels.Exceptions;

[Serializable]
public class OfflineException : Exception
{
	public OfflineException()
		: base(GetMethodName())
	{
	}

	private static string GetMethodName()
	{
		string name = new StackTrace(2).GetFrame(0).GetMethod().Name;
		return "Cannot call API Method: " + name + " in offline mode";
	}
}
