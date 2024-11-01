namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     Specifies the settings needed for retrieving a weather forecast.
/// </summary>
public class WeatherForecastQuerySettings
{
    /// <summary>
    ///     Sets the temperature unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return Celsius if none specified.</remarks>
    public TemperatureUnit Temperature { get; set; } = TemperatureUnit.Celsius;

    /// <summary>
    ///     Sets the wind speed unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return kilometers per hour if none specified.</remarks>
    public WindSpeedUnit WindSpeed { get; set; } = WindSpeedUnit.KilometersPerHour;

    /// <summary>
    ///     Sets the precipitation unit for the weather forecast.
    /// </summary>
    /// <remarks>Will by default return millimeters if none specified.</remarks>
    public PrecipitationUnit Precipitation { get; set; } = PrecipitationUnit.Millimeter;

    /// <summary>
    ///     Sets the time format for the weather forecast.
    /// </summary>
    /// <remarks>Will be default return ISO8601 of none specified.</remarks>
    public TimeFormat TimeFormat { get; set; } = TimeFormat.Iso8601;
}