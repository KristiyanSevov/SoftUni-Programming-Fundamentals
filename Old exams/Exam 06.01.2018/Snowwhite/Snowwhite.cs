using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string name = inputs[0];
                string color = inputs[1];
                int physics = int.Parse(inputs[2]);

                string ID = name + ":" + color;
                if (!dwarfs.ContainsKey(ID))
                {
                    dwarfs.Add(ID, physics);
                }
                else
                {
                    dwarfs[ID] = Math.Max(dwarfs[ID], physics);
                }

                input = Console.ReadLine();
            }
            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1])
                                             .Count()))
            {
                Console.WriteLine("({0}) {1} <-> {2}", 
                    dwarf.Key.Split(':')[1],
                    dwarf.Key.Split(':')[0],
                    dwarf.Value);
            }
        }
    }
}
