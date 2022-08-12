using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Services;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiveDayController : ControllerBase
    {
        private readonly ActiveDayService _activeDayService;

        public ActiveDayController(ActiveDayService activeDayService)
        {
            _activeDayService = activeDayService;
        }
    }
}
