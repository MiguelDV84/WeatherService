using Microsoft.OpenApi.Any;
using WeatherAPP.Models;

namespace WeatherAPP.Repositories
{
    public interface IWeatherRepository
    {
        public Task<WeatherData> GetWeatherDataFromApiAsync(string location);
    }
}
