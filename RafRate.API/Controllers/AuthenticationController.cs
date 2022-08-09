using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticateService)
        {
            _authenticationService = authenticateService;
        }
    }
}
