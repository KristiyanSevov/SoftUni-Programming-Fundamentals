using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            var broadcasts = new List<KeyValuePair<string, string>>();
            var messages = new List<KeyValuePair<string, string>>();
            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                int index = input.IndexOf(" <-> ");
                if (index == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string first = input.Substring(0, index);
                string second = input.Substring(index + 5);
                if (first.ToCharArray().All(x => char.IsDigit(x)) && second.ToCharArray().All(y => char.IsLetterOrDigit(y)))
                {
                    first = string.Join("", first.ToCharArray().Reverse());
                    messages.Add(new KeyValuePair<string, string>(first, second));
                }
                else if ((!first.ToCharArray().Any(x => char.IsDigit(x))) && second.ToCharArray().All(y => char.IsLetterOrDigit(y)))
                {
                    var result = new StringBuilder();
                    foreach (var c in second.ToCharArray())
                    {
                        if (char.IsLower(c))
                        {
                            result.Append(c.ToString().ToUpper());
                        }
                        else if (char.IsUpper(c))
                        {
                            result.Append(c.ToString().ToLower());
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                    string res = result.ToString();
                    broadcasts.Add(new KeyValuePair<string, string>(res, first));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var kvp in broadcasts)
                {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                }
            }
            Console.WriteLine("Messages: ");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var kvp in messages)
                {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
