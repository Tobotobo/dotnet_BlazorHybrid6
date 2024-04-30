using BlazorHybrid.Model.Entities;

namespace BlazorHybrid.Model.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetWeatherForecastAsync(int count);
}
