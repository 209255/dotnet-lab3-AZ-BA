using System;
using Newtonsoft.Json;
using System.Net;

namespace JTTT_1._0
{
    public class WeatherService
    {
        const string apiKey = "&APPID=c819d50df217e7ec4cac02f1ebb05965";
        const string baseURL = "http://api.openweathermap.org/data/2.5/weather?q=";
        const string defaultCountry = "pl";
        const string countryDelimiter = ",";
        const string iconBaseURL = "http://openweathermap.org/img/w/";

        public WeatherInfo.RootObject GetCurrentWeather(string city)
        {
            string jsonWeather = DownloadWeatherInfo(city);
            return Parse(jsonWeather);
        }

        public string GetWeatherImg(WeatherInfo.RootObject weather)
        {
            return FileDownloader.DownloadImg(iconBaseURL + weather.weather[0].icon + ".png");
        }

        string DownloadWeatherInfo(string city)
        {
            var client = new WebClient();
            Console.WriteLine(baseURL + city + countryDelimiter + defaultCountry + apiKey);
            return client.DownloadString(baseURL + city + countryDelimiter + defaultCountry + apiKey);
        }

        WeatherInfo.RootObject Parse(string json)
        {
            WeatherInfo.RootObject weather = new WeatherInfo.RootObject();
            Console.Write(json);
            try {
               weather = JsonConvert.DeserializeObject<WeatherInfo.RootObject>(json);
            }
            catch
            {
                Console.WriteLine("parse errrrrorrrrrs!");
                throw;
            }
            return weather;
        }

    }
}
