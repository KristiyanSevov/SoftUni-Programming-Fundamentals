using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new Dictionary<string, HashSet<string>>();
            var names = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "Time for Code")
            {
                if (!TestInput(input, out string ID, out List<string> remainingInputs))
                {
                    input = Console.ReadLine();
                    continue;
                }
                string eventName = remainingInputs[0];
                string[] participants = remainingInputs.Skip(1).ToArray();
                if (!names.ContainsKey(ID))
                {
                    names.Add(ID, eventName);
                }
                if (!events.ContainsKey(ID))
                {
                    events.Add(ID, new HashSet<string>());
                    foreach (var person in participants)
                    {
                        events[ID].Add(person);
                    }
                }
                else if (events.ContainsKey(ID) && eventName == names[ID])
                {
                    foreach (var person in participants)
                    {
                        events[ID].Add(person);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var ev in events.OrderByDescending(x => x.Value.Count).ThenBy(x => names[x.Key]))
            {
                Console.WriteLine("{0} - {1}", names[ev.Key], ev.Value.Count());
                foreach (var person in ev.Value.OrderBy(x => x))
                {
                    Console.WriteLine(person);
                }
            }
        }

        private static bool TestInput(string input, out string ID, out List<string> remainingInputs)
        {
            ID = String.Empty;
            remainingInputs = new List<string>();
            int index = input.IndexOf('#');
            if (index == -1 || index == 0 || input[index - 1] != ' ' )
            {
                return false;
            }
            string[] inputs = input.Split('#');
            ID = inputs[0].Trim();
            remainingInputs = inputs[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (remainingInputs.Count == 0)
            {
                return false;
            }
            foreach (var item in remainingInputs.Skip(1))
            {
                if (!item.StartsWith("@"))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
