using Microsoft.EntityFrameworkCore;
using RafRate.Data.Interfaces;

namespace RafRate.Data.Repositories.Base;

using System.Linq.Expressions;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class
{
    protected readonly DbContext _context;

    protected readonly DbSet<TEntity> _dbSet;

    public BaseRepository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        var newEntity = await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return newEntity.Entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _dbSet;
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.FirstOrDefaultAsync(expression);
    }

    public async Task RemoveAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
