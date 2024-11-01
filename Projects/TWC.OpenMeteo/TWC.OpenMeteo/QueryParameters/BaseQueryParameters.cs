using Refit;

namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     A base class with the required properties for making request to the API.
/// </summary>
public class BaseQueryParameters(double latitude, double longitude)
{
    /// <summary>
    ///     Sets the latitude coordinate for the weather forecast.
    /// </summary>
    /// <example>52.52</example>
    [AliasAs("latitude")]
    private double Latitude { get; set; } = latitude;

    /// <summary>
    ///     Sets the longitude coordinate for the weather forecast.
    /// </summary>
    /// <example>13.41</example>
    [AliasAs("longitude")]
    private double Longitude { get; set; } = longitude;

    /// <summary>
    ///     Sets the timezone to retrieve the weather forecast in.
    /// </summary>
    /// <remarks>If not specified it will try to autodetect the time zone.</remarks>
    [AliasAs("timezone")]
    public Timezone Timezone { get; set; } = Timezone.AutoDetect;

    /// <summary>
    ///     Sets the amount of days to get weather forecast for.
    /// </summary>
    [AliasAs("forecast_days")]
    public ForecastDays Days { get; set; } = ForecastDays.Seven;
    
    /// <summary>
    ///     Sets the temperature unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return Celsius if none specified.</remarks>
    [AliasAs("temperature_unit")]
    public TemperatureUnit Temperature { get; set; } = TemperatureUnit.Celsius;

    /// <summary>
    ///     Sets the wind speed unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return kilometers per hour if none specified.</remarks>
    [AliasAs("wind_speed_unit")]
    public WindSpeedUnit WindSpeed { get; set; } = WindSpeedUnit.KilometersPerHour;

    /// <summary>
    ///     Sets the precipitation unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return millimeters if none specified.</remarks>
    [AliasAs("precipitation_unit")]
    public PrecipitationUnit Precipitation { get; set; } = PrecipitationUnit.Millimeter;

    /// <summary>
    ///     Sets the time format for the weather forecast.
    /// </summary>
    /// <remarks>Will be default return ISO8601 of none specified.</remarks>
    [AliasAs("timeformat")]
    public TimeFormat TimeFormat { get; set; } = TimeFormat.Iso8601;
}