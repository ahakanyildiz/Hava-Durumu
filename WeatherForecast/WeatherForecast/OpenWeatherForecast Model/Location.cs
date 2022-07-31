namespace WeatherForecast.OpenWeatherForecast_Model
{
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string Tz_id { get; set; }
        public Int64 Localtime_epoch { get; set; }
        public string Localtime { get; set; }

    }
}
