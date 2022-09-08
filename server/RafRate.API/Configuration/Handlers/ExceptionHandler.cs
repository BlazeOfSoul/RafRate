using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Diagnostics;

namespace RafRate.API.Configuration.Handlers;

public static class ExceptionHandler
{
    public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app)
    {
        return app.UseExceptionHandler(a => a.Run(async context =>
        {
            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            var exception = exceptionHandlerPathFeature.Error;

            if (exception is ValidationException validationException)
            {
                await context.Response.WriteAsync(validationException.Message);
            }
            else
                await context.Response.WriteAsync(exception.Message);
        }));
    }
}