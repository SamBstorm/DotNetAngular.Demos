using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAngular.Demos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("v1/WeatherDemo/")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public static WeatherForecast wf { get; set; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet]
        [Route("Listing")]
        [Route("[action]")]
        [Route("/[action]/[controller]")]
        [Route("Weathers")]
        public IEnumerable<WeatherForecast> List()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("ChooseOne/{id?}")]
        public WeatherForecast GetOne(int? id)
        {
            id ??= 1;
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray()[(int)id];
        }

        [HttpGet("TestString/MSG={message:int}")]
        public string GiveMeAString(string message)
        {
            if(message.ToLower() == "Toto".ToLower())
            return message;
            return "BadWord";
        }

        [HttpPost]
        public ActionResult Post()
        {
            if (wf is null)
            {
                wf = new WeatherForecast() { TemperatureC = 12, Date = DateTime.Now, Summary = "Cloudy" };
                return Ok();
            }
            return BadRequest(new { status = 405 });
        }

        /*
        GET(All)  : domain/[controller]/ 
        GET  : domain/[controller]/{id}
        POST : domain/[controller]/
        PUT  : domain/[controller]/{id}
        DELETE : domain/[controller]/{id}
         */
    }
}
