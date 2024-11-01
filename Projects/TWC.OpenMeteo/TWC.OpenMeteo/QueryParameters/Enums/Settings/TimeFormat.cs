using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     Sets the time format to be returned.
/// </summary>
public enum TimeFormat
{
    /// <summary>
    ///     Sets the time format for the request to be returned as ISO8601.
    /// </summary>
    /// <example>2022-12-31</example>
    [EnumMember(Value = "iso8601")]
    Iso8601 = 0,
    
    /// <summary>
    ///     Sets the time format for the request to be returned as UNIX timestamp.
    /// </summary>
    [EnumMember(Value = "unixtime")]
    Unix = 1
}