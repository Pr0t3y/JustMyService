namespace JustMyService.Weather;

public class OpenWeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "1b8ad6949111ec3d15031fafb811e5c7";
    private readonly string _apiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";

    public OpenWeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetWeatherAsync(string city)
    {
        var url = string.Format(_apiUrl, city, _apiKey);
        return await _httpClient.GetStringAsync(url);
    }
}