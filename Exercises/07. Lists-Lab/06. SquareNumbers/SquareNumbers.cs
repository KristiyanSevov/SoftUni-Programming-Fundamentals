using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }
            result = result.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
