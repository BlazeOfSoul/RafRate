using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;
using RafRate.Data.Contexts;
using RafRate.Data.Entities;

namespace RafRate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;
    private readonly AppDbContext _dbContext;

    public AuthenticationController(IAuthenticationService authenticateService, AppDbContext dbContext)
    {
        _authenticationService = authenticateService;
        _dbContext = dbContext;
    }

    // test method
    [HttpGet]
    [Route("users")]
    public async Task<ActionResult<List<UserEntity>>> GetUsers() =>
        new List<UserEntity>
        {
            new()
            {
                Email = "test@gmail.com",
                FullName = "testTest",
                Nickname = "TESTER",
                PasswordHash = "1111",
                Role = 1
            }
        };
}
