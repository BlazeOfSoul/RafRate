using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;
using RafRate.Core.Services;

namespace RafRate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentService _commentService;

    public CommentController(CommentService commentService)
    {
        _commentService = commentService;
    }
}