namespace WeatherForecast.OpenWeatherForecast_Model
{
    public class Current
    {
        public Int64 Last_updated_epoch { get; set; }
        public string Last_updated { get; set; }
        public int Temp_c { get; set; }
        public int Temp_f { get; set; }
        public int is_day { get; set; }
        public Condition Condition { get; set; }
        public float Wind_mph { get; set; }
        public float Wind_kph { get; set; }
        public int Wind_degree { get; set; }
        public string Wind_dir { get; set; }
        public int Pressure_mb { get; set; }
        public float Pressure_in { get; set; }
        public int Precip_mm { get; set; }
        public int Precip_in { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public float Feelslike_c { get; set; }
        public float Feelslike_f { get; set; }
        public int Vis_km { get; set; }
        public int Vis_miles { get; set; }
        public int Uv { get; set; }
        public float Gust_mph { get; set; }
        public float Gust_kph { get; set; }

    }
}
