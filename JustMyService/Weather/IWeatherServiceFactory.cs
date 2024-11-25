using JustMyService.Weather;

public interface IWeatherServiceFactory
{
    IWeatherService CreateWeatherService(string service);
}