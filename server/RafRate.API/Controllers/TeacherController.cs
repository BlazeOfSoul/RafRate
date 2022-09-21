using Microsoft.AspNetCore.Mvc;
using RafRate.Core.Interfaces;
using RafRate.Core.Services;

namespace RafRate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeacherController(TeacherService teacherService) => this._teacherService = teacherService;
}
