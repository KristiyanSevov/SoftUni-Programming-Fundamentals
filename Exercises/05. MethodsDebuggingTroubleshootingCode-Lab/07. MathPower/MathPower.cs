using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(num, power));
        }

        static double Power(double num, int power)
        {
            double total = 1;
            for (int i = 0; i < power; i++)
            {
                total *= num;
            }
            return total;
        }
    }
}
