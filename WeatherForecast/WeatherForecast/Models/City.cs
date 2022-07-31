﻿
using System.ComponentModel.DataAnnotations;

namespace WeatherForecast.Models
{
    public class City
    {
        [Display(Name = "City Name:")]
        public string Name { get; set; }

        [Display(Name = "Temp.")]
        public string Temperature { get; set; }

        [Display(Name = "Humidity")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }
    }
}
