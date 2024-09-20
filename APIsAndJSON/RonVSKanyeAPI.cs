using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void kanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($" kanye: {kanyeQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" kanye: {kanyeQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" kanye: {kanyeQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" kanye: {kanyeQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" kanye: {kanyeQuote}");
            Console.WriteLine($"-----------------------");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var RonURl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var RonsResponse = client.GetStringAsync(RonURl).Result;


            var RonQuote = JArray.Parse(RonsResponse).ToString().Replace('[', ' ').Replace('[', ' ').Trim();

            Console.WriteLine($" Ron {RonQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" Ron {RonQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" Ron {RonQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" Ron {RonQuote}");
            Console.WriteLine($"-----------------------");
            Console.WriteLine($" Ron {RonQuote}");
        }
    }
}
