using Infra.Config;
using Infra.ErrorException;
using Infra.Http.Middleware;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddExceptionHandler<ErrorHandler>();
        builder.Services.AddProblemDetails();

        builder.Services.AddApplicationTransients(builder.Configuration);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHsts();
        }


        app.UseStatusCodePages();

        app.UseRequestLocalization();
        app.UseRouting();
        app.UseEndpoints(Routes.UseRoutes);
        app.UseMiddleware<ErrorMiddleware>();
        app.UseExceptionHandler();

        app.Run();
    }
}
