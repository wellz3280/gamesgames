namespace Infra.ErrorException;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

public class ProblemDatailsHandler : IProblemDetailsWriter
{

    public int? Status {get; set;}

    public string? Type { get; set; }

    public string? Title { get; set; }

    public bool CanWrite(ProblemDetailsContext context)
        => context.HttpContext.Response.StatusCode == 400;

    public ValueTask WriteAsync(ProblemDetailsContext context)
    {
        var response = context.HttpContext.Response;
        var exceptionHandlerPathFeature =
                context.HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        var errorWraper = new {
            Code    = response.StatusCode,
            Message = "chegando la",
            // Message = exceptionHandlerPathFeature.Error.Message,
            // Type    = exceptionHandlerPathFeature.Error.GetType().ToString(),
            Type    = "oq eu quier",
        };

        return new ValueTask(response.WriteAsJsonAsync(new {error = errorWraper}));
    }
}

public class MessageWrapper
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("code")]
    public int Code { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

}
