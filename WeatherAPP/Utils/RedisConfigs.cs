using StackExchange.Redis;

namespace WeatherAPP.Utils
{
    public static class RedisConfigs
    {
        public static IConnectionMultiplexer ConfigurationRedis(string connectionString)
        {
            return ConnectionMultiplexer.Connect(connectionString);
        }
    }
}
