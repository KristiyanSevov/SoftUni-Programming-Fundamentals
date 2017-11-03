using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            printPrimes(GetPrimes(start, end));
        }

        private static void printPrimes(List<int> primes)
        {
            for (int i = 0; i < primes.Count - 1; i++)
            {
                Console.Write("{0}, ", primes[i]);
            }
            if (primes.Count != 0)
            {
                Console.WriteLine(primes[primes.Count - 1]);
            }
            else
            {
                Console.WriteLine("(empty list)");
            }
        }

        private static List<int> GetPrimes(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool IsPrime(int num)
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