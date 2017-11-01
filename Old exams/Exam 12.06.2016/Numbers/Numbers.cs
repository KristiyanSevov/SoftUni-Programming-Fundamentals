using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sorted = nums.Where(x => x > nums.Average()).OrderByDescending(x => x);
            Console.WriteLine(sorted.Any() ? string.Join(" ", sorted.Take(5)) : "No");
        }
    }
}
