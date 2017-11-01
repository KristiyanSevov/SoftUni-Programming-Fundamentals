using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var countries = new SortedDictionary<string, int>();
            var cities = new Dictionary<string, long>();
            while (input != "stop")
            {
                string country = Regex.Match(input, @"([A-Z].*?)\\").Groups[1].Value;
                string city = Regex.Match(input, @"(^|\\)([^A-Z].*?)\\").Groups[2].Value;
                long population = long.Parse(input.Substring(input.LastIndexOf("\\") + 1));
                country = String.Join("", Regex.Matches(country, @"[^0-9@$#&]").Cast<Match>().Select(x => x.Value));
                city = String.Join("", Regex.Matches(city, @"[^0-9@$#&]").Cast<Match>().Select(x => x.Value));
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, 1);
                }
                else
                {
                    countries[country]++;
                }
                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, population);
                }
                else
                {
                    cities[city] = population;
                }
                input = Console.ReadLine();
            }
            foreach (var country in countries)
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);
            }
            foreach (var city in cities.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine("{0} -> {1}", city.Key, city.Value);
            }
        }
    }
}
