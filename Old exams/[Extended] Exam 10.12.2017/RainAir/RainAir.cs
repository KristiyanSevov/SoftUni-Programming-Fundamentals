using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "I believe I can fly!")
            {
                if (!input.Contains("="))
                {
                    string[] inputs = input.Split(' ');
                    string name = inputs[0];
                    List<int> flights = inputs.Skip(1).Select(int.Parse).ToList();
                    if (!customers.ContainsKey(name))
                    {
                        customers.Add(name, flights);
                    }
                    else
                    {
                        customers[name].AddRange(flights);
                    }
                }
                else
                {
                    string[] inputs = input.Split(new String[] {" = "}, StringSplitOptions.None);
                    string first = inputs[0];
                    string second = inputs[1];
                    customers[first] = customers[second].ToList();
                }
                input = Console.ReadLine();
            }
            foreach (var name in customers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("#{0} ::: {1}", name.Key, string.Join(", ", name.Value.OrderBy(x => x)));
            }
        }
    }
}
