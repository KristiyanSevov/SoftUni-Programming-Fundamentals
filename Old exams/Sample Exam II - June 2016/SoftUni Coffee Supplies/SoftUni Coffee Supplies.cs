using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUni_Coffee_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, string>();
            var coffee = new Dictionary<string, long>();
            string[] delimiters = Console.ReadLine().Split(' ');
            string input = Console.ReadLine();
            while (input != "end of info")
            {
                if (input.Contains(delimiters[0]))
                {
                    string[] inputs = input.Split(new string[] { delimiters[0] }, StringSplitOptions.None);
                    string name = inputs[0];
                    string type = inputs[1];
                    if (!people.ContainsKey(name))
                    {
                        people.Add(name, type);
                    }
                    if (!coffee.ContainsKey(type))
                    {
                        coffee.Add(type, 0);
                    }
                }
                else if (input.Contains(delimiters[1]))
                {
                    string[] inputs = input.Split(new string[] { delimiters[1] }, StringSplitOptions.None);
                    string coffeeType = inputs[0];
                    int quantity = int.Parse(inputs[1]);
                    if (!coffee.ContainsKey(coffeeType))
                    {
                        coffee.Add(coffeeType, quantity);
                    }
                    else
                    {
                        coffee[coffeeType] += quantity;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var type in coffee.Where(x => x.Value == 0))
            {
                Console.WriteLine("Out of {0}", type.Key);
            }

            input = Console.ReadLine();
            while (input != "end of week")
            {
                string[] inputs = input.Split(' ');
                string name = inputs[0];
                int drank = int.Parse(inputs[1]);
                if (drank < coffee[people[name]])
                {
                    coffee[people[name]] -= drank;
                }
                else
                {
                    Console.WriteLine("Out of {0}", people[name]);
                    coffee[people[name]] = 0;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Coffee Left:");
            foreach (var type in coffee.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} {1}", type.Key, type.Value);
            }
            Console.WriteLine("For:");
            foreach (var person in people.Where(x => coffee[x.Value] > 0).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine("{0} {1}", person.Key, person.Value);
            }
        }
    }
}
