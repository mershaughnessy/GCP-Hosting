using GcpHosting.Models;
using Microsoft.AspNetCore.Mvc;

namespace GcpHosting.Controllers;

[ApiController]
[Route("api/pickle-rick")]
public class PickleRickController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new PickleRickModel()
        {
            Name = "Pickle Rick"
        });
    }
}