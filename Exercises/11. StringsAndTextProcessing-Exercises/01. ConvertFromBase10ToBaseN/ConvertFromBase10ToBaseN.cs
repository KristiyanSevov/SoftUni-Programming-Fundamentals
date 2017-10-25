using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int numBase = int.Parse(inputs[0]);
            BigInteger num = BigInteger.Parse(inputs[1]);

            var result = new StringBuilder();
            int remainder = 0;
            while (num != 0)
            {
                remainder = (int)(num % numBase);
                result.Append(remainder);
                num = num / numBase;
            }
            Console.WriteLine(String.Join("", result.ToString().Reverse()));
        }
    }
}
