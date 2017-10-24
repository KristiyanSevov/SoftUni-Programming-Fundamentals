using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main()
        {
            var pokemon = new Dictionary<string, List<KeyValuePair<string, int>>>();
            string input = Console.ReadLine();
            while (input != "wubbalubbadubdub")
            {
                string[] inputs = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputs.Length == 1)
                {
                    string name = inputs[0];
                    if (pokemon.ContainsKey(name))
                    {
                        Console.WriteLine("# {0}", name);
                        foreach (var kvp in pokemon[name])
                        {
                            Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
                        }
                    }
                }
                else
                {
                    string name = inputs[0];
                    string evolution = inputs[1];
                    int evoIndex = int.Parse(inputs[2]);
                    if (!pokemon.ContainsKey(name))
                    {
                        pokemon.Add(name, new List<KeyValuePair<string, int>>());
                    }
                    pokemon[name].Add(new KeyValuePair<string, int>(evolution, evoIndex));
                }
                input = Console.ReadLine();
            }
            foreach (var name in pokemon)
            {
                Console.WriteLine("# {0}", name.Key);
                foreach (var kvp in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
