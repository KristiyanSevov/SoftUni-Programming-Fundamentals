using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishName
{
    class Program
    {
        static void Main()
        {
            long num = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(EnglishName(num));
        }

        private static string EnglishName(long num)
        {
            long digit = num % 10;
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "fail";
            }
        }
    }
}