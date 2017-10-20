using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
	    string command = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int count = 1;
            string resource = String.Empty;
            int quantity = 0;
            while (command != "stop")
            {
                if (count % 2 != 0)
                {
                    resource = command;
                }
                else
                {
                    quantity = int.Parse(command);
                    if (dict.ContainsKey(resource))
                    {
                        dict[resource] += quantity;
                    }
                    else
                    {
                        dict.Add(resource, quantity);
                    }
                }
                count++;
                command = Console.ReadLine();
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
