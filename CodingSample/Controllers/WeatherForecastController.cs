using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingSample.Abstractions.Models;
using CodingSample.Abstractions.Repositories;
using CodingSample.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherForcastRepository _repostiory;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcastRepository repository)
        {
            _logger = logger;
            _repostiory = repository;
        }

        [HttpGet("{days}")]
        public async Task<IEnumerable<WeatherForecast>> Get(int days)
        {
            return await _repostiory.GetWeatherForcast(days);
        }
    }
}
