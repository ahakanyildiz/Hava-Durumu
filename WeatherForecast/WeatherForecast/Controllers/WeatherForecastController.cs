using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models;
using WeatherForecast.OpenWeatherForecast_Model;
using WeatherForecast.Repositories;

namespace WeatherForecast.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWForecastRepository _forecastRepository;

        public WeatherForecastController(IWForecastRepository wForecastRepository)
        {
            _forecastRepository = wForecastRepository;
        }

        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResponse weatherResponse = _forecastRepository.GetForecast(city);
            City viewModel=new City();
            if (weatherResponse!=null)
            {
                viewModel.Name = weatherResponse.Location.Name;
                viewModel.Temperature = weatherResponse.Current.Temp_c + "°";
                viewModel.Humidity = weatherResponse.Current.Humidity;
                viewModel.Pressure = weatherResponse.Current.Pressure_mb;
                viewModel.Weather = weatherResponse.Current.Condition.Text;
                viewModel.Wind = weatherResponse.Current.Wind_mph;
            }
            return View(viewModel);
        }
    }
}
