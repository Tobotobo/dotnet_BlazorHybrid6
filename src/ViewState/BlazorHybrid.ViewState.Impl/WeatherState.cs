using BlazorHybrid.Model.Entities;
using BlazorHybrid.Model.Interfaces;

namespace BlazorHybrid.ViewState.Impl;

public class WeatherState(IWeatherForecastService weatherForecastService) : IWeatherState
{
    public WeatherForecast[]? WeatherForecasts { get; private set; }

    public async Task GetWeatherForecastAsync()
    {
        WeatherForecasts = await weatherForecastService.GetWeatherForecastAsync(5);
    }
}
