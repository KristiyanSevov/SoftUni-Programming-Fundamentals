using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestLength = 1;
            int length = 1;
            int value = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    length++;
                }
                if (arr[i] != arr[i + 1] ||
                    arr[i] == arr[i + 1] && i == arr.Length - 2)
                {
                    if (length > bestLength)
                    {
                        bestLength = length;
                        value = arr[i];
                    }
                    length = 1;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
