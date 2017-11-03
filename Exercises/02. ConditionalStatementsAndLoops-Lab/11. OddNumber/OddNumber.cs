using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            while (true)
            {
                int n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 != 0)
                {
                    Console.WriteLine("The number is: {0}", n);
                    return;
                }
                Console.WriteLine("Please write an odd number.");
            }
        }
    }
}
