using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(odd);
                sum += odd;
                odd += 2;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
