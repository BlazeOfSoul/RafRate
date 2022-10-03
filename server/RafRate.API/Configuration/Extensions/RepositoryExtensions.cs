using RafRate.Data.Entities;
using RafRate.Data.Interfaces;
using RafRate.Data.Repositories;

namespace RafRate.API.Configuration.Extensions;

using Data.Entities.Comments;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class, IEntity
        where TRepository : class, IBaseRepository<TEntity>
        => services.AddScoped<IBaseRepository<TEntity>, TRepository>();

    public static IServiceCollection ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
        => services.AddRepository<CommentEntity, CommentRepository>();
}
