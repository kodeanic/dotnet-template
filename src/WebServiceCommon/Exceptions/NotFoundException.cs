using System.Net;

namespace WebServiceCommon.Exceptions;

public class NotFoundException(string title, object? details = null)
    : AbstractHttpException(HttpStatusCode.NotFound, title, details);
