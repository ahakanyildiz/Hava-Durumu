using WeatherForecast.OpenWeatherForecast_Model;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
namespace WeatherForecast.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
        public WeatherResponse GetForecast(string city)
        {
            string APP_ID = Configuration.Values.OPEN_WEATHER_APP_ID;
            string baseUrl= "http://api.weatherapi.com/v1/current.json?key="+APP_ID +"&q="+ city + "&aqi=no" ; 
            var client = new RestClient(baseUrl);
            var request = new RestRequest("/",Method.Get);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherResponse>();
            }
            else
                return null;
        }
    }
}
