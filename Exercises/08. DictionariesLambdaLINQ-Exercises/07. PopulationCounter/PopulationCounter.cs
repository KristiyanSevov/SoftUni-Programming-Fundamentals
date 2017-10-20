using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
	    var countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] inputs = input.Split('|');
                string city = inputs[0];
                string country = inputs[1];
                long population = long.Parse(inputs[2]);
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }
                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, population);
                }
                input = Console.ReadLine();
            }
            foreach (var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})", country.Key,
                                                  country.Value.Values.Sum());
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
