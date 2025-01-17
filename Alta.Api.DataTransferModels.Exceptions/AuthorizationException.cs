using System;
using System.Runtime.Serialization;

namespace Alta.Api.DataTransferModels.Exceptions;

[Serializable]
public class AuthorizationException : Exception
{
	public AuthorizationException()
	{
	}

	public AuthorizationException(string message)
		: base(message)
	{
	}

	public AuthorizationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected AuthorizationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
