using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
	    int n = int.Parse(Console.ReadLine());
            var types = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string type = inputs[0];
                string name = inputs[1];
                int damage = inputs[2] != "null" ? int.Parse(inputs[2]) : 45;
                int health = inputs[3] != "null" ? int.Parse(inputs[3]) : 250;
                int armor = inputs[4] != "null" ? int.Parse(inputs[4]) : 10;

                if (!types.ContainsKey(type))
                {
                    types.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
                }
                if (!types[type].ContainsKey(name))
                {
                    types[type].Add(name, new Dictionary<string, int>{ { "damage", 0 },
                                                                        {"health", 0 },
                                                                        { "armor", 0 } });
                }
                types[type][name]["damage"] = damage;
                types[type][name]["health"] =  health;
                types[type][name]["armor"] = armor;
            }

            foreach (var type in types)
            {
                double averageDamage = type.Value.Values.Average(x => x["damage"]);
                double averageHealth = type.Value.Values.Average(x => x["health"]);
                double averageArmor = type.Value.Values.Average(x => x["armor"]);
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", type.Key, averageDamage,
                                                                averageHealth, averageArmor);
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Key, 
                        dragon.Value["damage"], dragon.Value["health"], dragon.Value["armor"]);
                }
            }
        }
    }
}
