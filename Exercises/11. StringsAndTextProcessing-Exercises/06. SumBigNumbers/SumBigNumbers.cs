using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            first = string.Join("", first.Reverse());
            second = string.Join("", second.Reverse());

            string padded = first.Length <= second.Length ? first.PadRight(second.Length, '0') : second.PadRight(first.Length, '0');
            string bigger = first.Length > second.Length ? first : second;
            var result = new StringBuilder();
            int current = 0;
            for (int i = 0; i < bigger.Length; i++)
            {
                int next = 0;
                current += padded[i] - 48 + bigger[i] - 48;
                if (current >= 10)
                {
                    next = 1;
                    current %= 10;
                }
                result.Append(current);
                current = next;
            }
            if (current == 1)
            {
                result.Append('1');
            }
            Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').Reverse()));
        }
    }
}
