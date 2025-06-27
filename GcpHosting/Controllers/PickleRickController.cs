using GcpHosting.Models;
using Microsoft.AspNetCore.Mvc;

namespace GcpHosting.Controllers;

[ApiController]
[Route("pickle-rick")]
public class PickleRickController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public PickleRickController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new PickleRickModel()
        {
            Name = "Pickle Rick"
        });
    }

    [HttpGet("ben")]
    public IActionResult Ben()
    {
        if (_configuration["BEN"].ToLower() == "true")
        {
            return Ok("Ben");
        }
    
        return BadRequest("Not Ben");
    }
}