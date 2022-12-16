using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Filters.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [MySampleActionFilter("User")]


    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "User Controller";
        }
    }
    [ApiController]
    [Route("api/[controller]")]
   [MySampleActionFilter("Weather")]
    public class WeatherForecastController : ControllerBase

    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) 
        {
              _logger= logger;
        }

        [HttpGet]
        [Route("WeatherForecast")]
       [MySampleActionFilter("Action")]
        public string Get() 
        {
            var rng = new Random();


            //Date = DateTime.Now.AddDays();
            /*int TemperatureC = rng.Next(-20, 55);
            return TemperatureC;*/
            string Summary = Summaries[rng.Next(Summaries.Length)];
            return Summary;
            //}).ToArray();
    }
        
    }
}
