using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;
using RafRate.Core.Services;

namespace RafRate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActiveDayController : ControllerBase
{
    private readonly IActiveDayService _activeDayService;

    public ActiveDayController(ActiveDayService activeDayService) => this._activeDayService = activeDayService;
}
