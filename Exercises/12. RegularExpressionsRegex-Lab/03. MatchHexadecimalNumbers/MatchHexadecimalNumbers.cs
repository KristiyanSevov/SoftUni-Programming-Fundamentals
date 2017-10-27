using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"\b0?x?[0-9A-F]+\b";
            string name = Console.ReadLine();
            var matches = Regex.Matches(name, pattern);
            var result = matches.Cast<Match>().Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
