using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

public enum WindSpeedUnit
{
    /// <summary>
    ///     Sets the wind speed unit to Km/H (Kilometers per Hour).
    /// </summary>
    [EnumMember(Value = "kmh")]
    KilometersPerHour = 0,
    
    /// <summary>
    ///     Sets te wind speed unit to m/s (Meters per Second).
    /// </summary>
    [EnumMember(Value = "ms")]
    MetersPerSecond = 1,
    
    /// <summary>
    ///     Sets the wind speed unit to MpH (Miles per Hour).
    /// </summary>
    [EnumMember(Value = "mph")]
    MilesPerHour = 2,
    
    /// <summary>
    ///     Sets the wind speed unit to Knots.
    /// </summary>
    [EnumMember(Value = "kn")]
    Knots = 3
}