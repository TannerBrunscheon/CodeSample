using CodingSample.Abstractions.Enumerations;
using CodingSample.Abstractions.Models;
using CodingSample.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingSample.Repositories
{
    public class WeatherForcastRepository : IWeatherForcastRepository
    {
        public WeatherForcastRepository()
        {
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForcast(int days)
        {
            var rng = new Random();

            //If we were actually making calls this would get extracted to a client
            //Task.FromResult is to make the function signature in the interface correct
            return await Task.FromResult(Enumerable.Range(1, days).Select(index =>
            new WeatherForecast(
                DateTime.Now.AddDays(index),
                rng.Next(-20, 55),
                ((WeatherSummary)rng.Next(Enum.GetNames(typeof(WeatherSummary)).Length)).ToString()
            ))
            .ToArray());
        }

    }
}
