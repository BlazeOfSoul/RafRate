using Microsoft.EntityFrameworkCore;
using RafRate.Data.Interaces;

namespace RafRate.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
    }
}
