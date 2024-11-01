namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     Sets the query parameters used for retrieving a current weather forecast.
/// </summary>
/// <remarks>Current conditions are based on 15-minutely weather model data.</remarks>
public class CurrentQueryOptions
{
    /// <summary>
    ///     Enables temperature 2 meters above ground.
    /// </summary>
    public bool Temperature2M { get; set; }
    
    /// <summary>
    ///     Enables relative humidity 2 meters above ground.
    /// </summary>
    public bool RelativeHumidity2M { get; set; }
    
    /// <summary>
    ///     Enables apparent temperature.
    /// </summary>
    public bool ApparentTemperature { get; set; }
    
    /// <summary>
    ///     Enables day or night value.
    /// </summary>
    public bool IdDayOrNight { get; set; }
    
    /// <summary>
    ///     Enables precipitation in the forecast.
    /// </summary>
    public bool Precipitation { get; set; }
    
    /// <summary>
    ///     Enables rain in the forecast.
    /// </summary>
    public bool Rain { get; set; }
    
    /// <summary>
    ///     Enables showers in the forecast.
    /// </summary>
    public bool Showers { get; set; }
    
    /// <summary>
    ///     Enables snowfall in the forecast.
    /// </summary>
    public bool Snowfall { get; set; }
    
    /// <summary>
    ///     Enables weather code in the forecast
    /// </summary>
    public bool WeatherCode { get; set; }
    
    /// <summary>
    ///     Enables cloud cover total in the forecast.
    /// </summary>
    public bool CloudCoverTotal { get; set; }
    
    /// <summary>
    ///     Enables sea level pressure in the forecast.
    /// </summary>
    public bool SeaLevelPressure { get; set; }
    
    /// <summary>
    ///     Enables surface pressure in the forecast.
    /// </summary>
    public bool SurfacePressure { get; set; }
    
    /// <summary>
    ///     Enables wind speed 10 meters above ground in the forecast.
    /// </summary>
    public bool WindSpeed10M { get; set; }
    
    /// <summary>
    ///     Enables wind direction 10 meters above ground in the forecast.
    /// </summary>
    public bool WindDirection10M { get; set; }
    
    /// <summary>
    ///     Enables wind gusts 10 meters above the ground in the forecast.
    /// </summary>
    public bool WindGusts10M { get; set; }

    /// <summary>
    ///     Runs throough each of the properties available in the <see cref="CurrentQueryOptions"/> and converts
    ///     them into a list that can be included in the current option when requesting the current forcast.
    /// </summary>
    /// <returns>Returns the enabled options as a string to include in the current weather forecast request.</returns>
    public override string ToString()
    {
        var enabledParameters = new List<string>();

        if (Temperature2M) enabledParameters.Add("temperature_2m");
        if (RelativeHumidity2M) enabledParameters.Add("relative_humidity_2m");
        if (ApparentTemperature) enabledParameters.Add("apparent_temperature");
        if (IdDayOrNight) enabledParameters.Add("is_day");
        if (Precipitation) enabledParameters.Add("precipitation");
        if (Rain) enabledParameters.Add("rain");
        if (Showers) enabledParameters.Add("showers");
        if (Snowfall) enabledParameters.Add("snowfall");
        if (WeatherCode) enabledParameters.Add("weather_code");
        if (CloudCoverTotal) enabledParameters.Add("cloud_cover");
        if (SeaLevelPressure) enabledParameters.Add("pressure_msl");
        if (SurfacePressure) enabledParameters.Add("surface_pressure");
        if (WindSpeed10M) enabledParameters.Add("wind_speed_10m");
        if (WindDirection10M) enabledParameters.Add("wind_direction_10m");
        if (WindGusts10M) enabledParameters.Add("wind_gusts_10m");

        return string.Join(",", enabledParameters);
    }
}