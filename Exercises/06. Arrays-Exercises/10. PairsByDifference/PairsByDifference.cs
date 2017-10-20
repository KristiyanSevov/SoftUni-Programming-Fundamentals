using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int pairs = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
