using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var info = new SortedDictionary<string, KeyValuePair<long, double>>();
            foreach (var name in names)
            {
                int health = 0;
                foreach (Match match in Regex.Matches(name, @"[^0-9+\-*\/.]"))
                {
                    health += match.Value[0];
                }
                string numPattern = @"(-?\d+\.\d+|-?\d+)";
                double damage = 0;
                foreach (Match match in Regex.Matches(name, numPattern))
                {
                    damage += double.Parse(match.Value);
                }
                foreach (char ch in name)
                {
                    if (ch == '*')
                    {
                        damage *= 2;
                    }
                    else if (ch == '/')
                    {
                        damage /= 2;
                    }
                }
                info.Add(name, new KeyValuePair<long, double>(health, damage));
            }
            foreach (var demon in info)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", demon.Key, demon.Value.Key, demon.Value.Value);
            }
        }
    }
}
