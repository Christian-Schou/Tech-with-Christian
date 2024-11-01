using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

public enum ForecastDays
{
    [EnumMember(Value = "1")]
    One = 1,
    
    [EnumMember(Value = "3")]
    Three = 3,
    
    [EnumMember(Value = "7")]
    Seven = 7,
    
    [EnumMember(Value = "14")]
    Fourteen = 14,
    
    [EnumMember(Value = "16")]
    Sixteen = 16
}