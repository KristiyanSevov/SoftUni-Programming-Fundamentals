using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int combos = 0;
            bool last = false;
            int lastFirst = 0;
            int lastSecond = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combos += 1;
                    if (i + j == magic)
                    {
                        last = true;
                        lastFirst = i;
                        lastSecond = j;
                    }
                }
            }
            if (!last)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combos, magic);
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastFirst, lastSecond, magic);
            }
        }
    }
}
