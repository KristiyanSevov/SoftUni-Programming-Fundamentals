using System;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surface = @"^[^a-zA-Z0-9]+$";
            string mantle = @"^[0-9_]+$";
            string core = @"^[^a-zA-Z0-9]+[0-9_]+([a-zA-Z]+)[0-9_]+[^a-zA-Z0-9]+$";
            int coreLength = 0;

            string pattern;
            int counter = 1;
            while (counter <= 5)
            {
                string line = Console.ReadLine();
                if (counter == 1 || counter == 5)
                {
                    pattern = surface;
                }
                else if (counter == 2 || counter == 4)
                {
                    pattern = mantle;
                }
                else
                {
                    pattern = core;
                    coreLength = Regex.Match(line, pattern).Groups[1].Length;
                }
                if (!Regex.IsMatch(line, pattern))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                counter++;
            }
            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }
    }
}
