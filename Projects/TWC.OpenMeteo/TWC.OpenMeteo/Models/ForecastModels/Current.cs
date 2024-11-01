using System.Text.Json.Serialization;

namespace TWC.OpenMeteo.Models.ForecastModels;

/// <summary>
///     Represents the API response containing information about current weather conditions.
/// </summary>
public class Current
{
    /// <summary>
    ///     Gets or sets the time for the current weather.
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    ///     Gets or sets the interval for the current weather.
    /// </summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>
    ///     Gets the temperature in <see cref="WeatherForecastOptions.Temperature_Unit"/>
    /// </summary>
    public float? Temperature { 
        get => Temperature2M;
        private set { }
    } 

    /// <summary>
    ///     Gets or sets the temperature 2m for the current weather.
    /// </summary>
    [JsonPropertyName("temperature_2m")]
    public float? Temperature2M { get; set; }

    /// <summary>
    ///     Gets or sets the relative humidity 2m for the current weather.
    /// </summary>
    [JsonPropertyName("relative_humidity_2m")]
    public float? RelativeHumidity2M { get; set; }

    /// <summary>
    ///     Gets or sets the apparent temperature for the current weather.
    /// </summary>
    [JsonPropertyName("apparent_temperature")]
    public float? ApparentTemperature { get; set; }

    /// <summary>
    ///     Gets or sets the id day value for the current weather.
    /// </summary>
    [JsonPropertyName("is_day")]
    public int IsDay { get; set; }

    /// <summary>
    ///     Gets or sets the precipitation value for the current weather.
    /// </summary>
    [JsonPropertyName("precipitation")]
    public float? Precipitation { get; set; }
    
    /// <summary>
    ///     Gets or sets the rain value for the current weather.
    /// </summary>
    [JsonPropertyName("rain")]
    public float? Rain { get; set; }
    
    /// <summary>
    ///     Gets or sets the showers value for the current weather.
    /// </summary>
    [JsonPropertyName("showers")]
    public float? Showers { get; set; }
    
    /// <summary>
    ///     Gets or sets the snowfall value for the current weather.
    /// </summary>
    [JsonPropertyName("snowfall")]
    public float? Snowfall { get; set; }
    
    /// <summary>
    ///     Gets or sets the WMO Weather interpretation code.
    /// <remarks>To get an actual string representation use <see cref="OpenMeteoClient.WeathercodeToString(int)"/></remarks>
    /// </summary>
    [JsonPropertyName("weather_code")]
    public int? WeatherCode { get; set; }
    
    /// <summary>
    ///     Gets or sets the cloud cover for the current weather.
    /// </summary>
    [JsonPropertyName("cloud_cover")]
    public int? CloudCover { get; set; }
    
    /// <summary>
    ///     Gets or sets the pressure msl value for the current weather.
    /// </summary>
    [JsonPropertyName("pressure_msl")]
    public float? PressureMsl { get; set; }
    
    /// <summary>
    ///     Gets or sets the surface pressure for the current weather.
    /// </summary>
    [JsonPropertyName("surface_pressure")]
    public float? SurfacePressure { get; set; }

    /// <summary>
    ///     Gets or sets the wind speed for the current weather.
    /// <remarks>Unit defined in <see cref="WeatherForecastOptions.Windspeed_Unit"/></remarks>
    /// </summary>
    [JsonPropertyName("wind_speed_10m")]
    public float? WindSpeed10M { get; set; }

    /// <summary>
    ///     Gets or sets the wind direction in degrees.
    /// </summary>
    [JsonPropertyName("wind_direction_10m")]
    public int? WindDirection10M { get; set; }
    
    /// <summary>
    ///     Gets or sets the wind gusts.
    /// </summary>
    [JsonPropertyName("wind_gusts_10m")]
    public float? WindGusts10M { get; set; }
}