using System.Runtime.CompilerServices;
using Refit;
using TWC.OpenMeteo.Models;
using TWC.OpenMeteo.QueryParameters;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace TWC.OpenMeteo;

// An interface for working with the Open-Meteo API.
internal interface IOpenMeteoApi
{
    [Get("forecast")]
    Task<WeatherForecast> GetCurrentWeatherAsync([Query] CurrentWeatherQueryParameters parameters);
}