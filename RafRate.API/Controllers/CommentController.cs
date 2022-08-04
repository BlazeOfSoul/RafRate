using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Services;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }
    }
}
