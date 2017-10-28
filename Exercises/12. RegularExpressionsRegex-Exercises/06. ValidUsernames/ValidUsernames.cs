using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
		.Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{2,24}$");
            string[] validNames = usernames.Where(x => pattern.IsMatch(x)).ToArray();
            int biggestLength = 0;
            string first = String.Empty;
            string second = String.Empty;
            for (int i = 0; i < validNames.Length - 1; i++)
            {
                int totalLength = validNames[i].Length + validNames[i + 1].Length;
                if (totalLength > biggestLength)
                {
                    first = validNames[i];
                    second = validNames[i + 1];
                    biggestLength = totalLength;
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
