using Microsoft.AspNetCore.Mvc;
using resPrsSpotApi.Models;
using resPrsSpotApi.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;

namespace resPrsSpotApi.Controllers
{
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
        public IActionResult Hw()
        {
            return Ok("Hello World");
        }

        [HttpPost("get")]
        public IActionResult Get([FromBody] GetMyModel x, [FromQuery] int y, [FromQuery] int z)
        {
            var result = new prs_Spot
            {
                maticnaEnotaField = 12,
                popolnoImeField = "ahoj",
                kratkoImeField = "adfsd"
            };

            return Ok(result);
        }

        [HttpPost("getList")]
        public IActionResult GetList([FromBody] GetMyModel x, [FromQuery] string y)
        {
            List<prs_Spot> rez = new List<prs_Spot>();

            for (int i = 0; i < 5; i++)
            {
                int randomValue = GetRandomInteger(0, 10);
                rez.Add(new prs_Spot
                {
                    maticnaEnotaField = randomValue,
                    popolnoImeField = "ahoj",
                    kratkoImeField = "adfsd"
                });
            }

            return Ok(rez);
        }

        static int GetRandomInteger(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1); // max + 1 da vkljuèimo zgornjo mejo
        }
    }
}
