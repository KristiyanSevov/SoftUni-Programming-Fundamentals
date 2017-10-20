using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(String.Join(" <= ", nums));
        }
    }
}
