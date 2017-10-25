using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var result = new StringBuilder();
            foreach (var c in text)
            {
                result.Append(String.Format("\\u{0:X4}", (int)c).ToLower());
            }
            Console.WriteLine(result);
        }
    }
}
