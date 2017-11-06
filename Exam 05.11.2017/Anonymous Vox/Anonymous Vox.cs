using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([a-zA-Z]+)(.+)\1";
            string text = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            int counter = 0;
            int index = 0;
            string lastAdded = String.Empty;
            int lastLength = 0;
            while (counter < values.Length && index < text.Length)
            {
                Match match = Regex.Match(text.Substring(index), pattern);
                if (!match.Success)
                {
                    break;
                }
                result.Append(text.Substring(index, match.Groups[2].Index));
                result.Append(values[counter]);
                result.Append(match.Groups[1].Value);
                lastAdded = match.Groups[1].Value;
                lastLength = match.Groups[1].Length;
                index += match.Groups[1].Index - index;
                index += match.Groups[1].Value.Length * 2 + match.Groups[2].Length;
                counter++;
            }
            int indexLast = text.LastIndexOf(lastAdded);
            string remaining = text.Substring(indexLast + lastLength);
            result.Append(remaining);
            Console.WriteLine(result);
        }
    }
}