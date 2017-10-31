using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^0-9]+)(\d+)";
            var result = new StringBuilder();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string message = match.Groups[1].Value.ToUpper();
                int num = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < num; i++)
                {
                    result.Append(message);
                }
            }
            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result);
        }
    }
}
