using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result;
            if (arr.Length >= arr2.Length)
            {
                result = SumArrays(arr, arr2);
            }
            else
            {
                result = SumArrays(arr2, arr);
            }
            foreach (var num in result)
            {
                Console.Write("{0} ", num);
            }
        }

        static int[] SumArrays(int[] larger, int[] smaller)
        {
            int[] res = new int[larger.Length];
            int j = 0;
            for (int i = 0; i < larger.Length; i++)
            {
                if (j >= smaller.Length)
                {
                    j = 0;
                }
                res[i] = larger[i] + smaller[j];
                j++;
            }
            return res;
        }
    }
}
