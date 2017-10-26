using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            HashSet<char> symbols = new HashSet<char>();
            var toPrint = new StringBuilder();
            var result = new StringBuilder();
            var num = new StringBuilder();
            var symbolsBuffer = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    symbolsBuffer.Append(text[i]);
                    toPrint.Append(text[i]);
                }
                else
                {
                    if (text[i] != '0')
                    {
                        foreach (var ch in symbolsBuffer.ToString().ToLower())
                        {
                            symbols.Add(ch);
                        }
                    }
                    symbolsBuffer = new StringBuilder();
                    num.Append(text[i]);
                    if (i == text.Length - 1 || !char.IsDigit(text[i+1]))
                    {
                        for (int j = 0; j < int.Parse(num.ToString()); j++)
                        {
                            result.Append(toPrint.ToString().ToUpper());
                        }
                        toPrint = new StringBuilder();
                        num = new StringBuilder();
                    }
                }
            }
            Console.WriteLine("Unique symbols used: {0}", symbols.Count);
            Console.WriteLine(result);
        }
    }
}
