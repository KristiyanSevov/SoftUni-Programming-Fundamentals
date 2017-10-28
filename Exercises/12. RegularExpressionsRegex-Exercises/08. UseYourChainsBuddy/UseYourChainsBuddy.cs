using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=<p>).*?(?=<\/p>)";
            var matches = Regex.Matches(text, pattern);
            List<string> results = new List<string>();
            foreach (Match match in matches)
            {
                string decoded = Regex.Replace(match.Value, @"[^a-z0-9]", " ");
                decoded = Regex.Replace(decoded, @"\s+", " ");
                StringBuilder result = new StringBuilder();
                foreach (char ch in decoded)
                {
                    if (Regex.IsMatch(ch.ToString(), "[a-m]"))
                    {
                        result.Append((char)(ch + 13));
                    }
                    else if (Regex.IsMatch(ch.ToString(), "[n-z]"))
                    {
                        result.Append((char)(ch - 13));
                    }
                    else
                    {
                        result.Append(ch);
                    }
                }
                results.Add(result.ToString());
            }
            Console.WriteLine(String.Join("", results));
        }
    }
}
