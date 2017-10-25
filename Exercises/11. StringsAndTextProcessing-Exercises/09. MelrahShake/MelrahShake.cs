using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
			
            while (true)
            {
                int leftIndex = text.IndexOf(pattern);
                int rightIndex = text.LastIndexOf(pattern);
                if (pattern.Length == 0 || leftIndex == -1 || rightIndex == -1 || rightIndex == leftIndex)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
                var newText = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == leftIndex || i == rightIndex)
                    {
                        i += pattern.Length - 1;
                    }
                    else
                    {
                        newText.Append(text[i]);
                    }
                }
                text = newText.ToString();
                Console.WriteLine("Shaked it.");
                var newPattern = new StringBuilder();
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (!(i == pattern.Length / 2))
                    {
                        newPattern.Append(pattern[i]);
                    }
                }
                pattern = newPattern.ToString();
            }
        }
    }
}
