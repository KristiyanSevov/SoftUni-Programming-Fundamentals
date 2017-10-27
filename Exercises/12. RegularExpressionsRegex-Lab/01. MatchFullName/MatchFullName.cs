using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\b[A-Z][a-z]+ [A-Z]{1}[a-z]+\b");
            string name = Console.ReadLine();
            var matches = reg.Matches(name);
            foreach (Match person in matches)
            {
                Console.Write(person.Value + " ");
            }
        }
    }
}
