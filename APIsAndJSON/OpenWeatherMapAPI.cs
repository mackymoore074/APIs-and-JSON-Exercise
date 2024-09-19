using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void OpenWeatherMap() 
        {
            var client = new HttpClient();

            var key = "47961f914abbac4c01e5a62fdca1ef93";
            var City = "Los Angeles";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={key}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;

            var Quote = JObject.Parse(response).ToString().Replace('[', ' ').Replace('[', ' ').Trim();

            Console.WriteLine(Quote);
        }

       
    }
}
