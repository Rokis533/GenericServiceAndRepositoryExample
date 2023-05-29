using WebApplication2.Repository;
using WebApplication2.service;

namespace WebApplication2.Service
{
    public interface IWeatherForecastService : IService<WeatherForecast>
    {

    }
    public class WeatherForecastService : Service<WeatherForecast>, IWeatherForecastService
    {
        public WeatherForecastService(IWeatherForecastRepository repository) : base(repository)
        {

        }

    }
}
