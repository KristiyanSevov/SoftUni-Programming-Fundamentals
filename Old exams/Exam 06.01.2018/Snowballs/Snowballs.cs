using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = -1;
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow((snow / time), quality);
                if (value > maxValue)
                {
                    result = String.Format("{0} : {1} = {2} ({3})", snow, time, value, quality);
                    maxValue = value;
                }
            }
            Console.WriteLine(result);
        }
    }
}
