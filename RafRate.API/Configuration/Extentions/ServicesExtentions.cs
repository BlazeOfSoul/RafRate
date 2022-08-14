using RafRate.Core.Services;
using RafRate.Core.Interfaces;

namespace RafRate.API.Configuration.Extentions;
public static class ServicesExtentions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
            => services.AddScoped<ICommentService, CommentService>()
                .AddScoped<IAuthenticationService, AuthenticationService>()
                .AddScoped<IActiveDayService, ActiveDayService>()
                .AddScoped<ITeacherService, TeacherService>();
    }

