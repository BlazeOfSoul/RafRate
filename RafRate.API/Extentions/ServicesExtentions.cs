using RafRate.Core.Services;
using RafRate.Data.Entities;
using RafRate.Data.Interaces;
using RafRate.Data.Repositories;

namespace RafRate.API.Extentions
{
    public static class ServicesExtentions
    {
        public static IServiceCollection AddRepository<TEntity, TRepository>(this IServiceCollection services)
            where TEntity : class, IEntity
            where TRepository : class, IRepository<TEntity>
            => services.AddScoped<IRepository<TEntity>, TRepository>();

        public static IServiceCollection ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
            => services.AddRepository<CommentEntity, CommentRepository>();

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
            => services.AddScoped<CommentService>()
                       .AddScoped<AuthenticationService>()
                       .AddScoped<EventService>()
                       .AddScoped<TeacherService>();
    }
}
