using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int bestCount = 0;
            int startIndex = 0;
            int bestStartIndex = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i+1])
                {
                    count++;
                }
                if (arr[i] >= arr[i + 1] || 
                   (arr[i] < arr[i + 1]) && (i == arr.Length-2))
                {
                    if (count > bestCount) 
                    {
                        bestCount = count;
                        bestStartIndex = startIndex;
                    }
                    count = 0;
                    startIndex = i + 1;
                }
            }
            for (int i = 0; i < bestCount+1; i++)
            {
                Console.Write("{0} ", arr[bestStartIndex]);
                bestStartIndex++;
            }
    }
}
