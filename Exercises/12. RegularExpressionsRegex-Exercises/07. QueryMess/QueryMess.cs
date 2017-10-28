using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                var fields = new Dictionary<string, List<string>>();
                string[] pairs = input.Split(new char[] { '?', '&' }).Where(x => x.Contains("=")).ToArray();
                foreach (var pair in pairs)
                {
                    string trasnformedPair = Regex.Replace(pair, @"(\s|\+|%20)+", " ").Trim();
                    string[] parsed = trasnformedPair.Split('=');
                    string field = parsed[0].Trim();
                    string value = parsed[1].Trim();
                    if (!fields.ContainsKey(field))
                    {
                        fields.Add(field, new List<string>());
                    }
                    fields[field].Add(value);
                }
                foreach (var field in fields)
                {
                    Console.Write("{0}=[{1}]", field.Key, String.Join(", ", field.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
