using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-Za-z]+)(?=\|)";
            var cities = new Dictionary<string, KeyValuePair<string, double>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string city = match.Groups["city"].Value;
                    string type = match.Groups["type"].Value;
                    double temp = double.Parse(match.Groups["temp"].Value);
                    if (!cities.ContainsKey(city))
                    {
                        cities.Add(city, new KeyValuePair<string, double>(type, temp));
                    }
                    else
                    {
                        cities[city] = new KeyValuePair<string, double>(type, temp);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var city in cities.OrderBy(x => x.Value.Value))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", city.Key, city.Value.Value, city.Value.Key);
            }
        }
    }
}
