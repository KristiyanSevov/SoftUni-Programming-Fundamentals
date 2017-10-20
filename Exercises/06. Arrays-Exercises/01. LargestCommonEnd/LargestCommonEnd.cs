using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int countFront = CountEquals(arr, arr2);
            Array.Reverse(arr);
            Array.Reverse(arr2);
            int countBack = CountEquals(arr, arr2);

            Console.WriteLine(Math.Max(countFront, countBack));
        }

        private static int CountEquals(string[] arr, string[] arr2)
        {
            int counter = 0;
            for (int i = 0; i < Math.Min(arr.Length, arr2.Length); i++)
            {
                if (arr[i] == arr2[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
