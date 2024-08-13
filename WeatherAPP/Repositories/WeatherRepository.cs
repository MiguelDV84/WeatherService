using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json;
using WeatherAPP.Models;

namespace WeatherAPP.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public WeatherRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<WeatherData> GetWeatherDataFromApiAsync(string location)
        {
            string apiKey = _configuration["VisualCrossing:ApiKey"];
            string url = $"https://api.tomorrow.io/v4/weather/forecast?location={location}&apikey=ZDIO0qpDSCjf4nWMa78iVSAptlJM2vjt";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WeatherData>(content);
            }

            return null;
        }
    }
}
