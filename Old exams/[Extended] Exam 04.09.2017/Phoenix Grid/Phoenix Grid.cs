using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\s_]{3}\.)*[^\s_]{3}$";
            string input = Console.ReadLine();
            while (input != "ReadMe")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success && IsPalindrome(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
