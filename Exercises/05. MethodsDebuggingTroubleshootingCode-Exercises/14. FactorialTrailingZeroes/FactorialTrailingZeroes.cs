using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CountOfTrailingZeros(Factorial(n)));
        }

        private static int CountOfTrailingZeros(BigInteger n)
        {
            int counter = 0;
            while (n % 10 == 0)
            {
                counter += 1;
                n /= 10;
            }
            return counter;
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}