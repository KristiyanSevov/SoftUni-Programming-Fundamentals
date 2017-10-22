using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hornet_Armada
{
    class Program
    {
        static void Main()
        {
            var activities = new Dictionary<string, int>();
            var legions = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int activity = int.Parse(inputs[0]);
                string legion = inputs[1];
                string type = inputs[2];
                int count = int.Parse(inputs[3]);

                if (!legions.ContainsKey(legion))
                {
                    legions.Add(legion, new Dictionary<string, long>());
                    activities.Add(legion, activity);
                }
                else
                {
                    if (activity > activities[legion])
                    {
                        activities[legion] = activity;
                    }
                }
                if (!legions[legion].ContainsKey(type))
                {
                    legions[legion].Add(type, count);
                }
                else
                {
                    legions[legion][type] += count;
                }
            }

            string input = Console.ReadLine();
            int index = input.IndexOf("\\") - 1;
            if (input.Contains('\\') && index >= 0 && char.IsDigit(input[index])) //for names with '\' inside - no judge test for that though
            {

                int activity = int.Parse(input.Substring(0, index + 1));
                string type = input.Substring(index + 2);

                foreach (var legion in legions.Where(x => x.Value.ContainsKey(type))
                    .Where(x => activities[x.Key] < activity)
                    .OrderByDescending(x => x.Value[type]))
                {
                    Console.WriteLine("{0} -> {1}", legion.Key, legion.Value[type]);
                }
            }
            else
            {
                foreach (var legion in legions.Where(x => x.Value.ContainsKey(input))
                    .OrderByDescending(x => activities[x.Key]))
                {
                    Console.WriteLine("{0} : {1}", activities[legion.Key], legion.Key);
                }
            }
        }
    }
}
