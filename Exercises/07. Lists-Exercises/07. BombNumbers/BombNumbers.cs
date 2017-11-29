using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGround
{
    class Test
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombInfo[0];
            int power = bombInfo[1];

            while (nums.Contains(bomb))
            {
                int bombIndex = nums.IndexOf(bomb);
                int elementsOnRight = Math.Min(power, nums.Count - 1 - bombIndex);
                int elementsOnLeft = Math.Min(bombIndex, power);
                int startIndex = Math.Max(bombIndex - power, 0);
                nums.RemoveRange(startIndex, elementsOnLeft + 1 + elementsOnRight);
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
