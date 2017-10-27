using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?(\d+|\d+\.\d+)($|(?=\s))";
            string name = Console.ReadLine();
            var matches = Regex.Matches(name, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }          
        }
    }
}
