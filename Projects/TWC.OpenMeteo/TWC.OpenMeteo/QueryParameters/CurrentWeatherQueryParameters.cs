using Refit;

namespace TWC.OpenMeteo.QueryParameters;

/// <summary>
///     A class with query parameters to make a query to get the current weather.
/// </summary>
public class CurrentWeatherQueryParameters : BaseQueryParameters
{
    /// <summary>
    ///     Get the current weather without specifying any additional options.
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    public CurrentWeatherQueryParameters(double latitude, double longitude) : base(latitude, longitude) { }

    /// <summary>
    ///     Get the current weather with additional options in the weather forecast request.
    /// </summary>
    /// <param name="latitude">Latitude coordinate.</param>
    /// <param name="longitude">Longitude coordinate.</param>
    /// <param name="queryOptions">Additional options for a current weather forecast request.</param>
    public CurrentWeatherQueryParameters(double latitude, double longitude, CurrentQueryOptions queryOptions) 
        : base(latitude, longitude)
    {
        Current = queryOptions.ToString();
    }

    [AliasAs("current")] private string? Current { get; set; }
}