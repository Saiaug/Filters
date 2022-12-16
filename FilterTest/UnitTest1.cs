using System;
using Filters;
using Filters.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace FilterTest
{
    public class UnitTest1
    {
       // private readonly ILogger<WeatherForecastController> _logger;
        [Fact]
        public void Testforuser()
        {
            UserController user = new UserController();
            string result = user.Get();
            Assert.Equal("User Controller", result);

        }

        /* "2022-12-15T20:32:50.4305284+05:30",
     "temperatureC": 8,
     "temperatureF": 46,
     "summary": "Chilly"*/

        [Fact]
        public void Testforweather()
        {
            //var mockrepo = Mock.Of<ILogger<WeatherForecastController>>();
            //ILogger<WeatherForecastController> logger = mockrepo.Object;

            //mockrepo.Setup(repo => repo.GetMany(null)).Returns(GetListBlog());
            //var controller = new BlogController(null, mockRepo.Object);

            var svc = new WeatherForecastController(new NullLogger<WeatherForecastController>());
            string result = svc.Get();
            
           Assert.Equal("Chilly", result);

            //var controller = new WeatherForecastController();
        }
    }

       



}