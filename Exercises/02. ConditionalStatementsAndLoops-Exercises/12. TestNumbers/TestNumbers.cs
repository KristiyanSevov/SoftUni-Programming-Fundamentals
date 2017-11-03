using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int sum = 0;
            int combos = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    combos += 1;
                    if (sum >= stop)
                    {
                        Console.WriteLine("{0} combinations", combos);
                        Console.WriteLine("Sum: {0} >= {1}", sum, stop);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations", combos);
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
