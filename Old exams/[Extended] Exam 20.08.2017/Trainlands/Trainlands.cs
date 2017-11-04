using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Dictionary<string, List<KeyValuePair<string, int>>>();
            string input = Console.ReadLine();
            while (input != "It's Training Men!")
            {
                if (input.Contains(":"))
                {
                    string[] inputs = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string name = inputs[0];
                    string[] wagonStuff = inputs[1].Split(new string[] { " : " }, StringSplitOptions.None);
                    string wagon = wagonStuff[0];
                    int power = int.Parse(wagonStuff[1]);
                    if (!trains.ContainsKey(name))
                    {
                        trains.Add(name, new List<KeyValuePair<string, int>>());
                    }
                    trains[name].Add(new KeyValuePair<string, int>(wagon, power));
                }
                else if (input.Contains("="))
                {
                    string[] inputs = input.Split(new string[] { " = " }, StringSplitOptions.None);
                    string train = inputs[0];
                    string other = inputs[1];
                    if (!trains.ContainsKey(train))
                    {
                        trains.Add(train, new List<KeyValuePair<string, int>>());
                    }
                    trains[train].Clear();
                    foreach (var kvp in trains[other])
                    {
                        trains[train].Add(new KeyValuePair<string, int>(kvp.Key, kvp.Value));
                    }
                }
                else
                {
                    string[] inputs = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string train = inputs[0];
                    string other = inputs[1];
                    if (!trains.ContainsKey(train))
                    {
                        trains.Add(train, new List<KeyValuePair<string, int>>());
                    }
                    foreach (var kvp in trains[other])
                    {
                        trains[train].Add(new KeyValuePair<string, int>(kvp.Key, kvp.Value));
                    }
                    trains.Remove(other);
                }
                input = Console.ReadLine();
            }
            foreach (var train in trains
                .OrderByDescending(x => x.Value.Select(y => y.Value).Sum())
                .ThenBy(x => x.Value.Count))
            {
                Console.WriteLine("Train: {0}", train.Key);
                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0} - {1}", wagon.Key, wagon.Value);
                }
            }
        }
    }
}
