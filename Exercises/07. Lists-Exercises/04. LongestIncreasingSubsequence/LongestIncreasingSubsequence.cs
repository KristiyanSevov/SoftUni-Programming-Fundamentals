using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int>[] results = new List<int>[nums.Length];
            int[] biggestCountAtIndex = new int[nums.Length];
            biggestCountAtIndex[0] = 1;
            results[0] = new List<int>();
            results[0].Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                biggestCountAtIndex[i] = 1;
                results[i] = new List<int>();
                results[i].Add(nums[i]);
                for (int j = 0; j < i; j++)
                {
                    if (biggestCountAtIndex[j] + 1 > biggestCountAtIndex[i] &&
                        nums[j] < nums[i])
                    {
                        biggestCountAtIndex[i] = biggestCountAtIndex[j] + 1;
                        results[i] = new List<int>(results[j]);
                        results[i].Add(nums[i]);
                    }
                }
            }
            int longestLength = biggestCountAtIndex.Max();
            int index = Array.IndexOf(biggestCountAtIndex, longestLength);
            Console.WriteLine(string.Join(" ", results[index]));
        }
    }
}
