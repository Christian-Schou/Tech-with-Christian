using System.Runtime.CompilerServices;
using TWC.OpenMeteo.Models;
using TWC.OpenMeteo.QueryParameters;

[assembly: InternalsVisibleTo("Test")]
namespace TWC.OpenMeteo.Services;

internal class OpenMeteoWeatherService(IOpenMeteoApi meteoApi) : IOpenMeteoWeatherService
{
    /// <inheritdoc/> 
    public async Task<WeatherForecast> GetCurrentWeatherForecastAsync(CurrentWeatherQueryParameters parameters)
    {
        return await meteoApi.GetCurrentWeatherAsync(parameters);
    }
}