namespace Infra.Http.Middleware;

using Microsoft.AspNetCore.Mvc;
using Simplify.Web.Responses;

public class ErrorMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorMiddleware> _logger;

    public ErrorMiddleware(
        RequestDelegate next,
        ILogger<ErrorMiddleware> logger
    ) {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An Exception as occured. {e}", e.Message);

            var ProblemDatails =  new ProblemDetails{
                Status  = StatusCodes.Status500InternalServerError,
                Title   = "Internal Server Error",
                Type    = context.GetType().ToString()
            };

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            await context.Response.WriteAsJsonAsync(ProblemDatails);
        }
    }
}
