using RafRate.Core.Interfaces;
using RafRate.Core.Services;

namespace RafRate.API.Extentions
{
    public static class ServicesExtentions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
            => services.AddScoped<CommentService>()
                       .AddScoped<AuthenticationService>()
                       .AddScoped<IActiveDayService>()
                       .AddScoped<TeacherService>();
    }
}
