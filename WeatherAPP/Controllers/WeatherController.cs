using Microsoft.AspNetCore.Mvc;
using WeatherAPP.Services;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("{location}")]
    public async Task<IActionResult> GetWeatherData(string location)
    {
        try
        {
            var data = await _weatherService.GetWeatherDataAsync(location);
            if (data == null)
            {
                return NotFound("No se encontraron datos para la ubicación proporcionada.");
            }

            return Ok(data);
        }
        catch (Exception ex)
        {
            // Manejo de errores apropiado
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
