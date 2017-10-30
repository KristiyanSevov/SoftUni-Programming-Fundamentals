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
            var toPrint = new StringBuilder();
            var result = new StringBuilder();
            var num = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    toPrint.Append(text[i]);
                }
                else
                {
                    num.Append(text[i]);
                    if (i == text.Length - 1 || !char.IsDigit(text[i + 1]))
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
            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result);
        }
    }
}
