using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] reversed = new int[arr.Length / 2];
            int index = 0;
            for (int i = arr.Length/4 - 1; i >= 0; i--)
            {
                reversed[index] = arr[i];
                index++;
            }
            for (int i = arr.Length-1; i >= arr.Length*3/4; i--)
            {
                reversed[index] = arr[i];
                index++;
            }
            int[] remaining = new int[arr.Length / 2];
            index = 0;
            for (int i = arr.Length / 4; i < arr.Length * 3 / 4; i++)
            {
                remaining[index] = arr[i];
                index++;
            }

            int[] result = new int[arr.Length / 2];
            for (int i = 0; i < reversed.Length; i++)
            {
                result[i] = reversed[i] + remaining[i];
            }

            foreach (var num in result)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
