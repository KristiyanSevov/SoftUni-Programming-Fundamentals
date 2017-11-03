using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterNumber
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (isPalindrome(i) && EvenDigit(i) && SumDivisibleBySeven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool EvenDigit(int num)
        {
            bool evenDigit = false;
            int digit;
            while (num > 0)
            {
                digit = num % 10;
                if (digit % 2 == 0)
                {
                    evenDigit = true;
                    break;
                }
                num /= 10;
            }
            return evenDigit;
        }

        private static bool SumDivisibleBySeven(int num)
        {
            int sum = 0;
            int digit;
            while (num > 0)
            {
                digit = num % 10;
                num /= 10;
                sum += digit;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isPalindrome(int num)
        {
            bool isPal = true;
            string s = num.ToString();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    isPal = false;
                    break;
                }
            }
            return isPal;
        }
    }
}