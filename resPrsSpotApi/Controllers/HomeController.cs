using Microsoft.AspNetCore.Mvc;
using resPrsSpotApi.Models;
using resPrsSpotApi.Classes;

namespace resPrsSpotApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("PozdravljenSvet")]
    public async Task<string> hw()
    {
        return "Hello World";
    }

    [HttpPost(Name = "get")]
    public async Task<Classes.prs_Spot> Get([FromBody] GetMyModel x, [FromQuery] int y, [FromQuery] int z)
    {
       
        //string iErr = null;
        //GetClientCert(ref iErr);
        return new Classes.prs_Spot { maticnaEnotaField=12.2, popolnoImeField="ahoj", kratkoImeField="adfsd" };
    }



 }
