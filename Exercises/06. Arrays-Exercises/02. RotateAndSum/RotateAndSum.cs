using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
   
            int[] sum = new int[arr.Length];
            for (int i = 0; i < n; i++)
            {
                arr = RotateArray(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }
            foreach (var num in sum)
            {
                Console.Write("{0} ", num);
            }
        }

        private static int[] RotateArray(int[] arr)
        {
            int[] res = new int[arr.Length];
            res[0] = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length-1; i++)
            {
                res[i+1] = arr[i];
            }
            return res;
        }
    }
}
