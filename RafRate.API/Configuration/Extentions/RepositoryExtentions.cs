using RafRate.Data.Entities;
using RafRate.Data.Interaces;
using RafRate.Data.Repositories;

namespace RafRate.API.Configuration.Extentions;

public static class RepositoryExtentions
{
    public static IServiceCollection AddRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class, IEntity
        where TRepository : class, IRepository<TEntity>
        => services.AddScoped<IRepository<TEntity>, TRepository>();
    
    public static IServiceCollection ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
        => services.AddRepository<CommentEntity, CommentRepository>();
}