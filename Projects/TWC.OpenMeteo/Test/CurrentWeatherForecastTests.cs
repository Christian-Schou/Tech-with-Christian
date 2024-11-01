using NSubstitute;
using TWC.OpenMeteo;
using TWC.OpenMeteo.Models;
using TWC.OpenMeteo.Models.ForecastModels;
using TWC.OpenMeteo.Models.Units;
using TWC.OpenMeteo.QueryParameters;
using TWC.OpenMeteo.Services;

namespace Test;

public class CurrentWeatherForecastTests
{
    [Fact]
    public async Task GetCurrentWeatherForecastAsync_ReturnsExpectedForecast()
    {
        // Arrange
        var latitude = 55.56179;
        var longitude = 10.28006;
        
        var mockMeteoApi = Substitute.For<IOpenMeteoApi>();
        var expectedForecast = new WeatherForecast
        {
            Latitude = (float)latitude,
            Longitude = (float)longitude
        };

        var parameters = new CurrentWeatherQueryParameters(latitude, longitude);

        // Set up the mock to return the expected forecast
        mockMeteoApi.GetCurrentWeatherAsync(parameters).Returns(Task.FromResult(expectedForecast));

        var service = new OpenMeteoWeatherService(mockMeteoApi);

        // Act
        var actualForecast = await service.GetCurrentWeatherForecastAsync(parameters);

        // Assert
        Assert.Equal(expectedForecast.Latitude, actualForecast.Latitude);
        Assert.Equal(expectedForecast.Longitude, actualForecast.Longitude);

        // Verify that the method was called exactly once with the specified parameters
        await mockMeteoApi.Received(1).GetCurrentWeatherAsync(parameters);
    }
    
    [Fact]
    public async Task GetCurrentWeatherForecastAsync_ReturnsExpectedForecast_WithOptions()
    {
        // Arrange
        var latitude = 55.56179;
        var longitude = 10.28006;
        
        var mockMeteoApi = Substitute.For<IOpenMeteoApi>();

        var currentQueryOptions = new CurrentQueryOptions
        {
            Precipitation = true,
            Temperature2M = true
        };
        
        var expectedForecast = new WeatherForecast
        {
            Latitude = (float)latitude,
            Longitude = (float)longitude,
            CurrentUnits = new CurrentUnits
            {
                Precipitation = "inch"
            },
            Current = new Current
            {
                Temperature2M = (float)11.3,
                Precipitation = (float)0.2
            }
        };
        
        var parameters = new CurrentWeatherQueryParameters(latitude, longitude, currentQueryOptions);
        parameters.Precipitation = PrecipitationUnit.Inch;
        
        // Set up the mock to return the expected forecast
        mockMeteoApi.GetCurrentWeatherAsync(parameters).Returns(Task.FromResult(expectedForecast));

        var service = new OpenMeteoWeatherService(mockMeteoApi);

        // Act
        var actualForecast = await service.GetCurrentWeatherForecastAsync(parameters);

        // Assert
        Assert.Equal(expectedForecast.Latitude, actualForecast.Latitude);
        Assert.Equal(expectedForecast.Longitude, actualForecast.Longitude);
        Assert.Equal("inch", actualForecast.CurrentUnits!.Precipitation);
        Assert.NotNull(actualForecast.Current);
        Assert.NotNull(actualForecast.Current.Precipitation);
        Assert.NotNull(actualForecast.Current.Temperature2M);

        // Verify that the method was called exactly once with the specified parameters
        await mockMeteoApi.Received(1).GetCurrentWeatherAsync(parameters);
    }
}