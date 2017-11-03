using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        private static bool IsPrime(long num)
        {
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}