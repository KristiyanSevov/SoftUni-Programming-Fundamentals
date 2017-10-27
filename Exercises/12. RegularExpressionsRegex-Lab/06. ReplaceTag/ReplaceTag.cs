using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string text = Console.ReadLine();
            while (text != "end")
            {
                string result = Regex.Replace(text, pattern, replacement);
                Console.WriteLine(result);
                text = Console.ReadLine();
            } 
        }
    }
}
