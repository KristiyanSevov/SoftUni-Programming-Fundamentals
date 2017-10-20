using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
			var premiums = new Dictionary<string, int>
            {
                {"motes", 0},
                {"fragments", 0},
                {"shards", 0}
            };
            var junk = new SortedDictionary<string, int>();
            bool achieved = false;
            string legendary = String.Empty;
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string type = input[i + 1].ToLower();
                    if (type == "motes" || type == "fragments" || type == "shards")
                    {
                        premiums[type] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(type))
                        {
                            junk.Add(type, quantity);
                        }
                        else
                        {
                            junk[type] += quantity;
                        }
                    }
                    foreach (var pair in premiums) //This part can be much simpler
                    {
                        if (pair.Key == "shards" && pair.Value >= 250)
                        {
                            achieved = true;
                            legendary = "Shadowmourne";
                            premiums["shards"] -= 250;
                            break;
                        }
                        else if ((pair.Key == "fragments" && pair.Value >= 250))
                        {
                            achieved = true;
                            legendary = "Valanyr";
                            premiums["fragments"] -= 250;
                            break;
                        }
                        else if (pair.Key == "motes" && pair.Value >= 250)
                        {
                            achieved = true;
                            legendary = "Dragonwrath";
                            premiums["motes"] -= 250;
                            break;
                        }
                    }
                    if (achieved)
                    {
                        break;
                    }
                }
                if (achieved)
                {
                    break;
                }
            }
            Console.WriteLine("{0} obtained!", legendary);
            foreach (var pair in premiums.OrderByDescending(x => x.Value)
                                         .ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            foreach (var pair in junk)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
