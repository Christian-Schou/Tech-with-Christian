using System.Runtime.Serialization;

namespace TWC.OpenMeteo.QueryParameters;

public enum Timezone
{
     [EnumMember(Value = "America/Anchorage")]
     AmericaAnchorage = 0,
     
     [EnumMember(Value = "America/Los_Angeles")]
     AmericaLosAngeles = 1,
     
     [EnumMember(Value = "America/Denver")]
     AmericaDenver = 2,
     
     [EnumMember(Value = "America/Chicago")]
     AmericaChicago = 3,
     
     [EnumMember(Value = "America/New_York")]
     AmericaNewYork = 4,
     
     [EnumMember(Value = "America/Sao_Paulo")]
     AmericaSaoPaulo = 5,
     
     [EnumMember(Value = "GMT")]
     Gmt = 6,
     
     [EnumMember(Value = "auto")]
     AutoDetect = 7,
     
     [EnumMember(Value = "Europe/London")]
     EuropeLondon = 8,
     
     [EnumMember(Value = "Europe/Berlin")]
     EuropeBerlin = 9,
     
     [EnumMember(Value = "Europe/Moscow")]
     EuropeMoscow = 10,
     
     [EnumMember(Value = "Africa/Cairo")]
     AfricaCairo = 11,
     
     [EnumMember(Value = "Asia/Bangkok")]
     AsiaBangkok = 12,
     
     [EnumMember(Value = "Asia/Singapore")]
     AsiaSingapore = 13,
     
     [EnumMember(Value = "Asia/Tokyo")]
     AsiaTokyo = 14,
     
     [EnumMember(Value = "Australia/Sydney")]
     AustraliaSydney = 15,
     
     [EnumMember(Value = "Pacific/Auckland")]
     PacificAuckland = 16
}