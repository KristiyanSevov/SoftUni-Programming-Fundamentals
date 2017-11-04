using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^<\[[^a-zA-Z0-9]*\]\.(\.\[[a-zA-Z0-9]*\]\.)*$";
            string input = Console.ReadLine();
            while (input != "Traincode!")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
