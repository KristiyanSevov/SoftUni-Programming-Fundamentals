using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int numBase = int.Parse(inputs[0]);
            string num = inputs[1];
            num = String.Join("", num.Reverse());
            BigInteger result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += int.Parse(num[i].ToString()) * ToPower(numBase, i);
            }
            Console.WriteLine(result);
        }

        private static BigInteger ToPower(int num, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
