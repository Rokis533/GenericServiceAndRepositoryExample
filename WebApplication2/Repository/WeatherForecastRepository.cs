using WebApplication2.repository;

namespace WebApplication2.Repository
{
    public interface IWeatherForecastRepository : IRepository<WeatherForecast>
    {
    }
    public class WeatherForecastRepository : Repository<WeatherForecast>, IWeatherForecastRepository
    {

    }
}
