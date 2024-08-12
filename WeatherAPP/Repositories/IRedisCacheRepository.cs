using WeatherAPP.Models;

namespace WeatherAPP.Repositories
{
    public interface IRedisCacheRepository
    {
        public Task<WeatherData> GetCacheWeatherDataAsync(string location);
        public Task SetCachedWeatherDataAsync(string location, WeatherData data);
    }
}
