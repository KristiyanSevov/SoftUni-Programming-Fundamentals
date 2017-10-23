using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var demons = new SortedDictionary<string, Dictionary<string, double>>();
            var symbols = new char[] { '+', '-', '*', '/', '.' };

            foreach (var demon in input)
            {
                double health = 0;
                double damage = 0;
                var num = new StringBuilder();
                for (int i = 0; i < demon.Length; i++)
                {
                    if (!char.IsDigit(demon[i]) && !symbols.Contains(demon[i]))
                    {
                        health += demon[i];
                    }
                    if (char.IsDigit(demon[i]) || (demon[i] == '.' && i != 0 && char.IsDigit(demon[i - 1]) && char.IsDigit(demon[i + 1])))
                    {
                        num.Append(demon[i]);
                    }
                    else
                    {
                        if (num.Length != 0)
                        {
                            if (i - num.Length - 1 >= 0 && demon[i - num.Length - 1] == '-')
                            {
                                damage -= double.Parse(num.ToString());
                            }
                            else
                            {
                                damage += double.Parse(num.ToString());
                            }
                            num = new StringBuilder();
                        }
                    }
                    if (i == demon.Length - 1 && num.Length != 0)
                    {
                        if (demon[i - num.Length] == '-')
                        {
                            damage -= double.Parse(num.ToString());
                        }
                        else
                        {
                            damage += double.Parse(num.ToString());
                        }
                    }
                }
                for (int i = 0; i < demon.Length; i++)
                {
                    if (demon[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (demon[i] == '/')
                    {
                        damage /= 2;
                    }
                }
                demons.Add(demon, new Dictionary<string, double>());
                demons[demon].Add("damage", damage);
                demons[demon].Add("health", health);
            }
            foreach (var demon in demons)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", demon.Key, demon.Value["health"], demon.Value["damage"]);
            }    
        }
    }
}
