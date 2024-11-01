using System.Text.Json.Serialization;

namespace TWC.OpenMeteo.Models.Units;

/// <summary>
///     Represents the metric value of the unit.
/// </summary>
public class CurrentUnits
{
    /// <summary>
    ///     Gets or sets the time unit.
    /// </summary>
    /// <example>iso8601</example>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
    
    /// <summary>
    ///     Gets or sets the interval unit.
    /// </summary>
    /// <example>seconds</example>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
    
    /// <summary>
    ///     Gets or sets the temperature 2m unit.
    /// </summary>
    /// <example>°C</example>
    [JsonPropertyName("temperature_2m")]
    public string? Temperature2M { get; set; }
    
    /// <summary>
    ///     Gets or sets the relative humidity 2m unit.
    /// </summary>
    /// <example>%</example>
    [JsonPropertyName("relative_humidity_2m")]
    public string? RelativeHumidity2M { get; set; }
    
    /// <summary>
    ///     Gets or sets the apparent temperature unit.
    /// </summary>
    /// <example>°C</example>
    [JsonPropertyName("apparent_temperature")]
    public string? ApparentTemperature { get; set; }
    
    /// <summary>
    ///     Gets or sets the is day unit.
    /// </summary>
    [JsonPropertyName("is_day")]
    public string? IsDay { get; set; }
    
    /// <summary>
    ///     Gets or sets the precipitation unit.
    /// </summary>
    /// <example>mm</example>
    [JsonPropertyName("precipitation")]
    public string? Precipitation { get; set; }
    
    /// <summary>
    ///     Gets or sets the rain unit.
    /// </summary>
    /// <example>mm</example>
    [JsonPropertyName("rain")]
    public string? Rain { get; set; }
    
    /// <summary>
    ///     Gets or sets the showers unit.
    /// </summary>
    /// <example>mm</example>
    [JsonPropertyName("showers")]
    public string? Showers { get; set; }
    
    /// <summary>
    ///     Gets or sets the snowfall unit.
    /// </summary>
    /// <example>cm</example>
    [JsonPropertyName("snowfall")]
    public string? Snowfall { get; set; }
    
    /// <summary>
    ///     Gets or sets the weather code unit.
    /// </summary>
    /// <example>wmo code</example>
    [JsonPropertyName("weather_code")]
    public string? WeatherCode { get; set; }
    
    /// <summary>
    ///     Gets or sets the cloud cover unit.
    /// </summary>
    /// <example>%</example>
    [JsonPropertyName("cloud_cover")]
    public string? CloudCover { get; set; }
    
    /// <summary>
    ///     Gets or sets the pressure msl unit.
    /// </summary>
    /// <example>hPa</example>
    [JsonPropertyName("pressure_msl")]
    public string? PressureMsl { get; set; }
    
    /// <summary>
    ///     Gets or sets the surface pressure unit.
    /// </summary>
    /// <example>hPa</example>
    [JsonPropertyName("surface_pressure")]
    public string? SurfacePressure { get; set; }
    
    /// <summary>
    ///     Gets or sets the wind speed 10m unit.
    /// </summary>
    /// <example>km/h</example>
    [JsonPropertyName("wind_speed_10m")]
    public string? WindSpeed10M { get; set; }
    
    /// <summary>
    ///     Gets or sets the wind direction 10m unit.
    /// </summary>
    /// <example>°</example>
    [JsonPropertyName("wind_direction_10m")]
    public string? WindDirection10M { get; set; }
    
    /// <summary>
    ///     Gets or sets the wind gusts 10m unit.
    /// </summary>
    /// <example>km/h</example>
    [JsonPropertyName("wind_gusts_10m")]
    public string? WindGusts10M { get; set; }
}