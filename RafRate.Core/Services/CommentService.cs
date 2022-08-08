using RafRate.Core.Interfaces;
using RafRate.Data.Entities;
using RafRate.Data.Interaces;

namespace RafRate.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<CommentEntity> _commentRepository;

        public CommentService(IRepository<CommentEntity> commentRepository)
        {
            _commentRepository = commentRepository;
        }
    }
}
