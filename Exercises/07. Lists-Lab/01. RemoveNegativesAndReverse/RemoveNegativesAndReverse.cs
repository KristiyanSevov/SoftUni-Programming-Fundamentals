using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool noPositive = true;
            for (int i = nums.Count-1; i >= 0; i--)
            {
                if (nums[i] >= 0)
                {
                    Console.Write($"{nums[i]} ");
                    noPositive = false;
                }
            }
            if (noPositive)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
