using System.Linq.Expressions;

namespace RafRate.Data.Interfaces;

public interface IBaseRepository<TEntity>
{
    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);

    Task RemoveAsync(TEntity entity);
}
