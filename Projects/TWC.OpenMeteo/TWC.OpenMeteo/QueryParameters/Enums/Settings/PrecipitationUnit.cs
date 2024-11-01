using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

public enum PrecipitationUnit
{
    /// <summary>
    ///     Sets the precipitation unit to millimeters.
    /// </summary>
    [EnumMember(Value = "mm")]
    Millimeter = 0,
    
    /// <summary>
    ///     Sets the precipitation unit to inches.
    /// </summary>
    [EnumMember(Value = "inch")]
    Inch = 1
}