using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     An enum specifying the temperature unit for the weather forecast.
/// </summary>
public enum TemperatureUnit
{
    /// <summary>
    ///     Sets Celsius °C as the temperature unit.
    /// </summary>
    [EnumMember(Value = "celsius")]
    Celsius = 0,
    
    /// <summary>
    ///     Sets Fahrenheit °F as the temperature unit.
    /// </summary>
    [EnumMember(Value = "fahrenheit")]
    Fahrenheit = 1
}