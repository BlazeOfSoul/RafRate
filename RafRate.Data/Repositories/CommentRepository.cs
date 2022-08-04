using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafRate.Data.Repositories
{
    public class CommentRepository : BaseRepository<CommentEntity, AppDbContext>
    {
        public CommentRepository(AppDbContext context)
            : base(context)
        { }
    }
   
}
