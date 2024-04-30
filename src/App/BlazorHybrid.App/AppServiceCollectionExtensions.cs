using BlazorHybrid.Model.Interfaces;
using BlazorHybrid.Model.Impl;
using BlazorHybrid.View;
using BlazorHybrid.ViewState;
using BlazorHybrid.ViewState.Impl;
using Microsoft.Extensions.DependencyInjection;

#if DEBUG
using BlazorHybrid.Model.Impl.Mock;
using BlazorHybrid.ViewState.Impl.Mock;
#endif

namespace BlazorHybrid.App;

public static class AppServiceCollectionExtensions
{
    public static IServiceCollection AddApp(this IServiceCollection services)
    {
        services
            .AddView()

            // .AddTransient<ICounterState, CounterState>()
            // .AddScoped<ICounterState, CounterState>()
            .AddSingleton<ICounterState, CounterState>()
            // .AddSingleton<ICounterState, CounterStateMock>()

            .AddTransient<IWeatherState, WeatherState>()
            // .AddTransient<IWeatherState, WeatherStateMock>()

            .AddSingleton<ICounterService, CounterService>()

            .AddSingleton<IWeatherForecastService, WeatherForecastService>()
        // .AddSingleton<IWeatherForecastService, WeatherForecastServiceMock>()
        ;

        return services;
    }
}
