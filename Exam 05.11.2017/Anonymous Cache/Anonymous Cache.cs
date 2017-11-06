using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "thetinggoesskrra")
            {
                string set = string.Empty;
                if (input.Contains('|'))
                {
                    string[] inputs = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string key = inputs[0];
                    string[] remInputs = inputs[1].Split(new string[] { " | " }, StringSplitOptions.None);
                    set = remInputs[1];
                    int size = int.Parse(remInputs[0]);
                    if (!data.ContainsKey(set))
                    {
                        if (!cache.ContainsKey(set))
                        {
                            cache.Add(set, new Dictionary<string, long>());
                        }
                        cache[set].Add(key, size);
                    }
                    else
                    {
                        data[set].Add(key, size);
                    }
                }
                else
                {
                    set = input;
                    if (!data.ContainsKey(set))
                    {
                        data.Add(set, new Dictionary<string, long>());
                        if (cache.ContainsKey(set))
                        {
                            foreach (var kvp in cache[set])
                            {
                                data[set].Add(kvp.Key, kvp.Value);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            if (data.Count == 0)
            {
                return;
            }
            foreach (var dataset in data.OrderByDescending(x => x.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine("Data Set: {0}, Total Size: {1}", dataset.Key, dataset.Value.Values.Sum());
                foreach (var key in dataset.Value)
                {
                    Console.WriteLine("$.{0}", key.Key);
                }
            }
        }
    }
}
