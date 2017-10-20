using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (arr.Length > 1)
            {
                arr = ReduceOne(arr);
            }
            Console.WriteLine(arr[0]);
        }

        static int[] ReduceOne(int[] arr)
        {
            int[] res = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                res[i] = arr[i] + arr[i + 1];
            }
            return res;
        }
    }
}
