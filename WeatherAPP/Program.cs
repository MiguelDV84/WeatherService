using StackExchange.Redis;
using WeatherAPP.Repositories;
using WeatherAPP.Services;
using WeatherAPP.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IWeatherRepository, WeatherRepository>(client =>
{
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddSingleton<IWeatherService, WeatherService>();
builder.Services.AddSingleton<IWeatherRepository, WeatherRepository>();
builder.Services.AddSingleton<IRedisCacheRepository, RedisCacheRepository>();
builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
    RedisConfigs.ConfigurationRedis(builder.Configuration.GetConnectionString("Redis")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
