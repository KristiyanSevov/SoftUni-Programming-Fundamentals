using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();
            int counter = 1;
            for (int i = 0; i < nums.Count-1; i++)
            { 
                if (nums[i] == nums[i+1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", nums[i], counter);
                    counter = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", nums[nums.Count - 1], counter);
        }
    }
}
