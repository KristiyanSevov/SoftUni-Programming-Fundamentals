using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n*i);
            }
            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n, multiplier, n * multiplier);
            }
        }
    }
}
