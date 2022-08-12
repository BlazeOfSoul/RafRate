using RafRate.Core.Services;
using Microsoft.EntityFrameworkCore;
using RafRate.Data.Contexts;

namespace RafRate.API.Configuration.Extentions
{
    public static class ServicesExtentions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
            => services.AddScoped<CommentService>()
                .AddScoped<AuthenticationService>()
                .AddScoped<ActiveDayService>()
                .AddScoped<TeacherService>();
    }
}
