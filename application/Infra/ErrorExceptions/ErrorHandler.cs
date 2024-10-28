namespace Infra.ErrorException;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

public class ErrorHandler : IExceptionHandler
{
    private readonly ILogger<ErrorHandler> _logger;

    public ErrorHandler(ILogger<ErrorHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken
    ) {

        _logger.LogError(exception, "An Exception as occured. {e}", exception.Message);

        var ProblemDatails =  new ProblemDetails{
            Status  = StatusCodes.Status500InternalServerError,
            Title   = "Internal Server Error",
            Type    = httpContext.GetType().ToString()
        };

        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

        await httpContext.Response.WriteAsJsonAsync(ProblemDatails, cancellationToken);

        return true;
    }
}
