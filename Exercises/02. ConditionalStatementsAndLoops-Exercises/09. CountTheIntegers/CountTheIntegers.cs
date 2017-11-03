using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    count += 1;
                }
                catch (Exception)
                {

                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
