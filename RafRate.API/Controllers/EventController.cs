using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Services;

namespace RafRate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }
    }
}
