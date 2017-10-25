using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            number = string.Join("", number.Reverse());

            var result = new StringBuilder();
            int current = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int next = 0;
                current += (number[i] - 48) * multiplier;
                if (current >= 10)
                {
                    next = current/10;
                    current %= 10;
                }
                result.Append(current);
                current = next;
            }
            if (current != 0)
            {
                result.Append(current.ToString());
            }
            string final = string.Join("", result.ToString().TrimEnd('0').Reverse());
            Console.WriteLine(final.Length != 0 ? final : "0");
        }
    }
}
