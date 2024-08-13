using WeatherAPP.Models;
using WeatherAPP.Repositories;

namespace WeatherAPP.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repository;
        private readonly IRedisCacheRepository _redisCacheRepository;

        public WeatherService(IWeatherRepository repository, IRedisCacheRepository redisCache)
        {
            _repository = repository;
            _redisCacheRepository = redisCache;
        }

        public async Task<WeatherData> GetWeatherDataAsync(string locaiton)
        {
            var weatherData = await _repository.GetWeatherDataFromApiAsync(locaiton);
            if (weatherData != null)
            {
                await _redisCacheRepository.SetCachedWeatherDataAsync(locaiton, weatherData);
            }


            var cachedData = await _redisCacheRepository.GetCacheWeatherDataAsync(locaiton);
            if (cachedData != null) 
            {
                return cachedData;
            }

           
            return null;
        }
    }
}
