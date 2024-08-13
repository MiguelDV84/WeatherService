using Microsoft.OpenApi.Any;
using WeatherAPP.Models;

namespace WeatherAPP.Services
{
    public interface IWeatherService
    {
        public Task<WeatherData> GetWeatherDataAsync(string location);
    }
}
