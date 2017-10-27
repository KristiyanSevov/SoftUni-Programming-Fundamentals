using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"(^| )\+359(-| )2\2\d{3}\2\d{4}\b");
            string name = Console.ReadLine();
            var matches = reg.Matches(name);
            var result = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
