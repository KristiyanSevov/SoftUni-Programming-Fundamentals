using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int originalCount = nums.Count;
            for (int j = 0; j < originalCount; j++)
            {
                for (int i = 0; i < nums.Count-1; i++)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        nums[i] += nums[i + 1];
                        nums.RemoveAt(i + 1);
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", nums));          
        }
    }
}
