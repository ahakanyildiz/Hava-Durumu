using WeatherForecast.OpenWeatherForecast_Model;

namespace WeatherForecast.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
