using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersReversedOrder
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            PrintReversedDigits(num);
        }

        private static void PrintReversedDigits(double num)
        {
            string number = num.ToString();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}