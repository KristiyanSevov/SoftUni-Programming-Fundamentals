using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var names = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] logs = Console.ReadLine().Split(' ');
                string name = logs[1];
                string IP = logs[0];
                int duration = int.Parse(logs[2]);
                if (!names.ContainsKey(name))
                {
                    names.Add(name, new SortedDictionary<string, int>());
                }
                if (!names[name].ContainsKey(IP))
                {
                    names[name].Add(IP, duration);
                }
                else
                {
                    names[name][IP] += duration;
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine("{0}: {1} [{2}]", name.Key, 
                    name.Value.Values.Sum(), string.Join(", ", name.Value.Keys));
            }
        }
    }
}
