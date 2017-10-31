using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternD = @"[^a-zA-Z-]+";
            string patternB = @"[a-zA-Z]+-[a-zA-Z]+";
            while (true)
            {
                Match didimon = Regex.Match(input, patternD);
                if (!didimon.Success)
                {
                    break;
                }
                Console.WriteLine(didimon.Value);
                input = input.Substring(didimon.Index + didimon.Value.Length);
                Match bojomon = Regex.Match(input, patternB);
                if (!bojomon.Success)
                {
                    break;
                }
                Console.WriteLine(bojomon.Value);
                input = input.Substring(bojomon.Index + bojomon.Value.Length);
            }
        }
    }
}
