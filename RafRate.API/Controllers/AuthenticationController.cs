using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Services;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthenticationController(AuthenticationService authenticateService)
        {
            _authenticationService = authenticateService;
        }
    }
}
