using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[a-z0-9][a-z0-9\-._]+@[a-z0-9][a-z0-9\-._]*\.[a-z0-9]+($|(?=[., \n]))";
            foreach (Match item in Regex.Matches(text, pattern))
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
