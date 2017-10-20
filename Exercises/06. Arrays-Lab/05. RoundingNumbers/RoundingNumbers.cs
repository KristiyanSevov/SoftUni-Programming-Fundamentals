using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        public static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i], Math.Round(arr[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
