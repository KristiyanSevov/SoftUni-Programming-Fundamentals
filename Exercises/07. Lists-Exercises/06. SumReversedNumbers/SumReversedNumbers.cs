using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            int result = Console.ReadLine()
                .Split(' ')
                .Select(x => string.Join("", x.Reverse()))
                .Select(int.Parse)
                .Sum();

            Console.WriteLine(result);
        }
    }
}
