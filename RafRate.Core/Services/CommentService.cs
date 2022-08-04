using RafRate.Core.Interfaces;
using RafRate.Data.Entities;
using RafRate.Data.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafRate.Core.Services
{
    public class CommentService
    {
        private readonly IRepository<CommentEntity> _commentRepository;

        public CommentService(IRepository<CommentEntity> commentRepository)
        {
            _commentRepository = commentRepository;
        }
    }
}
