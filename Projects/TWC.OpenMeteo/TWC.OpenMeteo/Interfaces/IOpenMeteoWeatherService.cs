using TWC.OpenMeteo.Models;
using TWC.OpenMeteo.QueryParameters;

namespace TWC.OpenMeteo;

public interface IOpenMeteoWeatherService
{
    /// <summary>
    ///     Get a current weather forecast from Open-Meteo.
    /// </summary>
    /// <param name="parameters">Query parameters</param>
    /// <returns>A Weather Forecast from Open-Meteo.</returns>
    Task<WeatherForecast> GetCurrentWeatherForecastAsync(CurrentWeatherQueryParameters parameters);
}