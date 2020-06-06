using System.Collections.Generic;
using System.Threading.Tasks;
using CodingSample.Abstractions.Models;

namespace CodingSample.Abstractions.Repositories
{
    public interface IWeatherForcastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForcast(int days);
    }
}