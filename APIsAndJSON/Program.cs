using Newtonsoft.Json.Linq;
using System;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            OpenWeatherMapAPI.OpenWeatherMap();

            RonVSKanyeAPI.kanyeQuote();

            RonVSKanyeAPI.RonQuote();

        }
    }
}
