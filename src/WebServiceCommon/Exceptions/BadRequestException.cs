using System.Net;

namespace WebServiceCommon.Exceptions;

public class BadRequestException(string title, object? details = null)
    : AbstractHttpException(HttpStatusCode.BadRequest, title, details);
