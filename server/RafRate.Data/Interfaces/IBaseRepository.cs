using System.Linq.Expressions;

namespace RafRate.Data.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : IEntity
{
    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);

    Task<TEntity> GetByIdAsync(Guid id);

    Task RemoveAsync(TEntity entity);
}
