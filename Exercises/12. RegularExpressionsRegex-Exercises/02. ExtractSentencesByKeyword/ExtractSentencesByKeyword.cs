using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = "\\b" + word + "\\b";
            string[] text = Console.ReadLine()
		.Split(new char[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(x => x.Trim()).ToArray();

            foreach (var sentence in text)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
