using Microsoft.AspNetCore.Mvc;
using OPP1;

namespace OPP1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly INumberGenerator _numberGenerator;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, INumberGenerator generator)
        {
            _logger = logger;
            _numberGenerator = generator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            return _numberGenerator.Generate();
        }
    }
}