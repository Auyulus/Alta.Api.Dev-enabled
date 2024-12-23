using System;
using System.Net;
using System.Net.Http;

namespace Alta.Api.DataTransferModels.Exceptions;

[Serializable]
public class HttpException : Exception
{
	public HttpResponseMessage Response { get; set; }

	public HttpWebResponse WebResponse { get; set; }

	public HttpStatusCode StatusCode { get; private set; }

	public HttpException(HttpStatusCode statusCode)
		: base("Server Error: " + statusCode)
	{
		StatusCode = statusCode;
	}
}
