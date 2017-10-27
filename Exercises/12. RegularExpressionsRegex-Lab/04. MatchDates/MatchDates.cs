using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string name = Console.ReadLine();
            var matches = Regex.Matches(name, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",
                    match.Groups["day"], match.Groups["month"], match.Groups["year"]);
            }          
        }
    }
}
