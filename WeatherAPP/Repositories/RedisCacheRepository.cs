using Microsoft.OpenApi.Any;
using Newtonsoft.Json;
using StackExchange.Redis;
using WeatherAPP.Models;

namespace WeatherAPP.Repositories
{
    public class RedisCacheRepository : IRedisCacheRepository
    {
        private readonly IDatabase _database;

        public RedisCacheRepository(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();
        }

        public async Task<WeatherData> GetCacheWeatherDataAsync(string location)
        {
            var data = await _database.StringGetAsync(location);

            if (!data.IsNullOrEmpty)
            {
                return JsonConvert.DeserializeObject<WeatherData>(data);
            }

            return null;
        }

        public async Task SetCachedWeatherDataAsync(string location, WeatherData data)
        {
            var weatherData = JsonConvert.SerializeObject(data);
            await _database.StringSetAsync(location, weatherData);
        }
    }
}
