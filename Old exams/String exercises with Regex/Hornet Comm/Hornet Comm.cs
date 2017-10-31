using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateM = @"^([0-9]+) <-> ([0-9a-zA-Z]+)$";
            string broadcast = @"^([^0-9]+) <-> ([0-9a-zA-Z]+)$";
            var messages = new List<KeyValuePair<string, string>>();
            var broadcasts = new List<KeyValuePair<string, string>>();
            while (input != "Hornet is Green")
            {
                if (Regex.IsMatch(input, privateM))
                {
                    Match match = Regex.Match(input, privateM);
                    string code = string.Join("", match.Groups[1].Value.Reverse());
                    messages.Add(new KeyValuePair<string, string>(code, match.Groups[2].Value));
                }
                else if (Regex.IsMatch(input, broadcast))
                {
                    Match match = Regex.Match(input, broadcast);
                    string frequency = match.Groups[2].Value;
                    string message = match.Groups[1].Value;
                    var result = new StringBuilder();
                    foreach (var c in frequency)
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
                    broadcasts.Add(new KeyValuePair<string, string>(result.ToString(), message));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count != 0)
            {
                foreach (var kvp in broadcasts)
                {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count != 0)
            {
                foreach (var kvp in messages)
                {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
