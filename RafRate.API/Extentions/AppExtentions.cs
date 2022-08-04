using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace RafRate.API.Extentions
{
    public static class AppExtentions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app)
        {
            return app.UseExceptionHandler(a => a.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                Exception exception = exceptionHandlerPathFeature.Error;

                if (exception is ValidationException validationException)
                {
                    await context.Response.WriteAsync(validationException.Message);
                }
                else
                    await context.Response.WriteAsync(exception.Message);
            }));
        }
    }
}
