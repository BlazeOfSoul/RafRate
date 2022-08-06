using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiveDayController : ControllerBase
    {
        private readonly IActiveDayService _activedayService;

        public ActiveDayController(IActiveDayService activedayService)
        {
            _activedayService = activedayService;
        }
    }
}
