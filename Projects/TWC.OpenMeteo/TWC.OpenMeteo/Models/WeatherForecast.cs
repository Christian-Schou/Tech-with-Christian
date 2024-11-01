using System.Text.Json.Serialization;
using TWC.OpenMeteo.Models.ForecastModels;
using TWC.OpenMeteo.Models.Units;

namespace TWC.OpenMeteo.Models;

/// <summary>
///     Represents the weather forecast API response.
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// Gets or sets the latitude coordinate.
    /// </summary>
    /// <remarks>This might be up to 5 km away from your latitude set-point.</remarks>
    [JsonPropertyName("latitude")]
    public float Latitude { get; set; }

    /// <summary>
    ///     Gets or sets the longitude coordinate.
    /// </summary>
    /// <remarks>This might be up to 5 km away from your longitude set-point.</remarks>
    [JsonPropertyName("latitude")]
    public float Longitude { get; set; }

    /// <summary>
    ///     Gets or sets the elevation in meters of the selected weather grid-cell.
    /// </summary>
    [JsonPropertyName("elevation")]
    public float Elevation { get; set; }

    /// <summary>
    ///     Gets or sets the generation time of the weather forecast in milliseconds.
    /// </summary>
    /// <remarks>The returned value is in milliseconds.</remarks>
    [JsonPropertyName("generationtime_ms")]
    public float GenerationTime { get; set; }

    /// <summary>
    ///     Gets or sets the applied timezone offset from the <see cref="WeatherForecastOptions.Timezone"/> parameter.
    /// </summary>
    /// <remarks>The returned value is in seconds.</remarks>
    [JsonPropertyName("utc_offset_seconds")]
    public int UtcOffset { get; set; }

    /// <summary>
    ///     Gets or sets the timezone identifier.
    /// </summary>
    /// <example>Europe/Copenhagen</example>
    public string? Timezone { get; set; }

    /// <summary>
    ///     Gets or sets the timezone abbreviation
    /// </summary>
    /// <example>CEST</example>
    [JsonPropertyName("timezone_abbreviation")]
    public string? TimezoneAbbreviation { get; set; }

    /// <summary>
    ///     Gets or sets the current weather conditions.
    /// </summary>
    [JsonPropertyName("current")]
    public Current? Current { get; set; }
    
    /// <summary>
    ///     Gets or sets the unit values for the current metrics.
    /// </summary>
    [JsonPropertyName("current_units")]
    public CurrentUnits? CurrentUnits { get; set; }
}