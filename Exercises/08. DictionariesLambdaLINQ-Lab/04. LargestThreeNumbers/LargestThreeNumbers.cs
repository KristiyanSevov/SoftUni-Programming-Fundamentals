using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
