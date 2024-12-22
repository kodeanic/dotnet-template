using System.Net;

namespace WebServiceCommon.Exceptions;

public abstract class AbstractHttpException : Exception
{
    protected AbstractHttpException(HttpStatusCode statusCode, string title, object? details = null)
        : base(title)
    {
    }
}
