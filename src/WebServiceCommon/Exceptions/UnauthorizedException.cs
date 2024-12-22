using System.Net;

namespace WebServiceCommon.Exceptions;

public class UnauthorizedException(string title, object? details = null)
    : AbstractHttpException(HttpStatusCode.Unauthorized, title, details);
