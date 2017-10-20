using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForNumber
{
    class SearchForNumber
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var list = nums.Take(arr[0]).ToList();
            list.RemoveRange(0, arr[1]);
            if (list.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
