using Microsoft.Extensions.DependencyInjection;
using Refit;
using TWC.OpenMeteo.Services;

namespace TWC.OpenMeteo.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Add Open-Meteo weather service to the service container.
    ///     Makes it possible to use <see cref="IOpenMeteoWeatherService"/> with dependency injection in your services.
    ///     <br />
    ///     <br />
    ///     This will also register the Http Client using HttpClientFactory and the Refit interface used
    ///     for making the API requests to Open-Meteo.
    /// </summary>
    /// <param name="services">The current service collection.</param>
    /// <returns>An updated service collection with Open-Meteo added.</returns>
    public static IServiceCollection AddOpenMeteoWeatherService(this IServiceCollection services)
    {
        // Register the Open-Meteo Client
        services
            .AddRefitClient<IOpenMeteoApi>()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://api.open-meteo.com/v1"));
        
        // Register the Open-Meteo weather wrapper service
        services.AddSingleton<IOpenMeteoWeatherService, OpenMeteoWeatherService>();
        
        return services;
    }
}