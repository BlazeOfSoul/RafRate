using Microsoft.EntityFrameworkCore;
using RafRate.Data.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafRate.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        protected readonly TContext _context;
        public BaseRepository(TContext context)
        {
            _context = context;
        }
    }
}
