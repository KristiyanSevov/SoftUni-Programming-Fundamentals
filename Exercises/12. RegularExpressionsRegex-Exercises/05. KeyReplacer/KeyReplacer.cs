using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"(?<start>^[A-Za-z]+)(<|\||\\).*?(<|\||\\)*(?<end>[A-Za-z]+$)";
            Match match = Regex.Match(keys, pattern);
            string startKey = match.Groups["start"].Value;
            string endKey = match.Groups["end"].Value;
            pattern = $@"(?<={startKey}).*?(?={endKey})";
            var matches = Regex.Matches(text, pattern);
            StringBuilder result = new StringBuilder();
            foreach (Match m in matches)
            {
                if (!(m.Value.Contains(startKey) && m.Value.Contains(endKey)))
                {
                    result.Append(m.Value);
                } 
            }
            if (result.Length != 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
