using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;
using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Core.Services;

namespace RafRate.API.Controllers
{
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
        [Route("Users")]
        public async Task<IActionResult> GetUsers()
        {
            List<UserEntity> listUsers = _dbContext.Users.ToList();
            try
            {
                if (listUsers != null)
                {
                    return Ok(listUsers);
                }

                return Ok("No Users in DB");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
