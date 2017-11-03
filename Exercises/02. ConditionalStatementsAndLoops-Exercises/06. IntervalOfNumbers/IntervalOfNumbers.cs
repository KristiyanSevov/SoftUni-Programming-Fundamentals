using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int a = Math.Max(x, y);
            int b = Math.Min(x, y);
            for (int i = b; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
