using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;

namespace RafRate.Data.Repositories;

using Entities.Comments;

public class CommentRepository : BaseRepository<CommentEntity>
{
    public CommentRepository(AppDbContext context)
        : base(context)
    {
    }
}
